using AviaPlace.AviaPlaceDataSetTableAdapters;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        UsersTableAdapter usersAdapter = new UsersTableAdapter();
        public UsersPage()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = usersAdapter.GetData().Select(user => new
            {
                Id = user.id,
                FullDisplay = $"{user.surname} {user.name} - {user.role}"
            }).ToList();
            UsersList.ItemsSource = users;
            UsersList.DisplayMemberPath = "FullDisplay";
            UsersList.SelectedValuePath = "Id";
        }

        private void UsersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsersList.SelectedItem != null)
            {
                var user = usersAdapter.GetData().FirstOrDefault(x => x.id == Convert.ToInt32(UsersList.SelectedValue));
                SurnameTbx.Text = user.surname;
                NameTbx.Text = user.name;
                emailTbx.Text = user.email;
                passwordTbx.Text = user.password;
                roleCbx.Text = user.role;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields(0))
            {
                usersAdapter.InsertQuery(SurnameTbx.Text, NameTbx.Text, emailTbx.Text, App.sha256(passwordTbx.Text),
                    roleCbx.Text, "None");
                App.WriteLog($"Добавлен пользователь - {SurnameTbx.Text} {NameTbx.Text}");
                Clear();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UsersList.SelectedItem != null && ValidateFields((int)UsersList.SelectedValue))
            {
                int selectedId = Convert.ToInt32(UsersList.SelectedValue);
                var avatar = usersAdapter.GetData().FirstOrDefault(x => x.id == selectedId).avatar;
                if (passwordTbx.Text.Length == 64) usersAdapter.UpdateQuery(SurnameTbx.Text, NameTbx.Text, emailTbx.Text, passwordTbx.Text, roleCbx.Text, avatar, selectedId);
                else usersAdapter.UpdateQuery(SurnameTbx.Text, NameTbx.Text, emailTbx.Text, App.sha256(passwordTbx.Text), roleCbx.Text, avatar, selectedId);
                App.WriteLog($"Изменен пользователь с идентификатором {selectedId}");
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UsersList.SelectedItem != null)
            {
                int selectedId = Convert.ToInt32(UsersList.SelectedValue);
                usersAdapter.DeleteQuery(selectedId);
                App.WriteLog($"Удален пользователь - {SurnameTbx.Text} {NameTbx.Text}");
                Clear();
            }
            else MessageBox.Show("Выберите пользователя для удаления");
        }

        private bool ValidateFields(int id)
        {
            if (string.IsNullOrWhiteSpace(SurnameTbx.Text) || string.IsNullOrWhiteSpace(NameTbx.Text) || string.IsNullOrWhiteSpace(emailTbx.Text) ||
                string.IsNullOrWhiteSpace(passwordTbx.Text) || string.IsNullOrWhiteSpace(roleCbx.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return false;
            }

            int validation = 0;
            string surnameP = @"^[А-Я][а-я]{2,25}$";
            if (Regex.IsMatch(SurnameTbx.Text, surnameP)) validation++;
            else MessageBox.Show("Неверный формат фамилии");
            string nameP = @"^[А-Я][а-я]{2,22}$";
            if (Regex.IsMatch(NameTbx.Text, nameP)) validation++;
            else MessageBox.Show("Неверный формат имени");
            string emailP = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+){1,35}$";
            if (Regex.IsMatch(emailTbx.Text, emailP))
            {
                var emails = usersAdapter.GetData().FirstOrDefault(x => x.email == emailTbx.Text);
                if (emails == null || emails.id == id) validation++;
                else MessageBox.Show("Почта уже занята!");
            }
            else MessageBox.Show("Неверный формат почты");
            string passwordP = @"^(?=.*[A-Za-z])(?=.*\d).{4,64}$";
            if (Regex.IsMatch(passwordTbx.Text, passwordP)) validation++;
            else MessageBox.Show("Неверный формат пароля");
            return validation == 4;
        }

        private void Clear()
        {
            SurnameTbx.Text = string.Empty;
            NameTbx.Text = string.Empty;
            emailTbx.Text = string.Empty;
            passwordTbx.Text = string.Empty;
            roleCbx.Text = string.Empty;
            LoadUsers();
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            var users = usersAdapter.GetData();

            if (users.Rows.Count > 0)
            {
                var saveFileDialog = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv" };

                if (saveFileDialog.ShowDialog() == true)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName, false, new System.Text.UTF8Encoding(true)))
                    {
                        writer.WriteLine(string.Join(",", users.Columns.Cast<DataColumn>().Select(col => col.ColumnName)));

                        foreach (DataRow row in users.Rows)
                        {
                            writer.WriteLine(string.Join(",", row.ItemArray));
                        }
                    }
                    App.WriteLog($"Экспортированы пользователи!");
                    MessageBox.Show("Данные успешно экспортированы!");
                }
            }
            else MessageBox.Show("Нет данных для экспорта!");
        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            List<UserModel> forImport = UserModel.DeserializeFromCsv();
            if (forImport != null)
            {
                foreach (UserModel model in forImport)
                {
                    MessageBox.Show(model.role);
                    usersAdapter.InsertQuery(model.surname, model.name, model.email, App.sha256(model.password), model.role, "None");
                }
                App.WriteLog($"Импортированы новые пользователи!");
                LoadUsers();
            }
        }
    }
}
