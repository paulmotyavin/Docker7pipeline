using AviaPlace.AviaPlaceDataSetTableAdapters;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        UsersTableAdapter usersAdapter = new UsersTableAdapter();
        public RegWindow()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            if (surnameTbx.Text.Length > 0 && nameTbx.Text.Length > 0 && emailTbx.Text.Length > 0 &&
                passwordTbx.Password.Length > 0 && againPasswordTbx.Password.Length > 0)
            {
                int validation = 0;
                string surnameP = @"^[А-Я][а-я]{1,}$"; // проврека валидации каждого поля
                if (Regex.IsMatch(surnameTbx.Text, surnameP)) validation++;
                else MessageBox.Show("Неверный формат фамилии");
                if (Regex.IsMatch(nameTbx.Text, surnameP)) validation++;
                else MessageBox.Show("Неверный формат имени");
                string emailP = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if (Regex.IsMatch(emailTbx.Text, emailP)) validation++;
                else MessageBox.Show("Неверный формат почты");
                string passwordP = @"^(?=.*[A-Za-z])(?=.*\d).{4,}$";
                if (Regex.IsMatch(passwordTbx.Password, passwordP)) validation++;
                else MessageBox.Show("Неверный формат пароля");
                if (passwordTbx.Password.Equals(againPasswordTbx.Password)) validation++;
                else MessageBox.Show("Пароли должны совпадать");
                if (validation == 5)
                {
                    usersAdapter.InsertQuery(surnameTbx.Text, nameTbx.Text, emailTbx.Text, App.sha256(passwordTbx.Password), "Клиент", @"C:\Users\paulscriptum\source\repos\AviaPlace\AviaPlace\imgs\avatar.png");
                    App.WriteLog($"Зарегистрирован новый пользователь с почтой {emailTbx.Text}");
                    new AuthWindow().Show();
                    this.Close();
                }
            }
        }

        private void authBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }
    }
}
