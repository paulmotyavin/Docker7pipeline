using AviaPlace.AviaPlaceDataSetTableAdapters;
using System;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AviaPlace
{

    public partial class ProfilePage : Page
    {
        Window window;
        UsersTableAdapter usersAdapter = new UsersTableAdapter();

        public ProfilePage(Window window)
        {
            InitializeComponent();
            this.window = window;
            var current_user = usersAdapter.GetData().FirstOrDefault(x => x.id == int.Parse(Properties.Settings.Default.userId));
            SurnameTb.Text = current_user.surname;
            NameTb.Text = current_user.name;
            EmailTb.Text = current_user.email;
            roleTb.Text = current_user.role;
            if (current_user.avatar != "None")
            {
                AvatarImg.Source = new BitmapImage(new Uri(current_user.avatar));
            }
            else AvatarImg.Source = new BitmapImage(new Uri(@"C:\Users\paulscriptum\source\repos\AviaPlace\AviaPlace\imgs\avatar.png"));

            if (!(this.window is AdminWindow))
            {
                BackupBtn.Visibility = Visibility.Hidden;
            }
        }


        // Событие нажатия на кнопку для выхода из аккаунта
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            App.WriteLog($"Пользователь {Properties.Settings.Default.userId} вышел из системы");
            Properties.Settings.Default.userId = "";
            Properties.Settings.Default.avatar = "None";
            Properties.Settings.Default.Save();
            AuthWindow auth = new AuthWindow();
            auth.Show();
            window.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedPath = openFileDialog.FileName;

                string saveDirectory = @"C:\Users\paulscriptum\source\repos\AviaPlace\images";

                string fileName = System.IO.Path.GetFileName(selectedPath);
                string destPath = System.IO.Path.Combine(saveDirectory, fileName);

                System.IO.File.Copy(selectedPath, destPath, true);

                AvatarImg.Source = new BitmapImage(new Uri(destPath));

                SaveImagePathToDatabase(destPath);
            }
        }

        private void SaveImagePathToDatabase(string imagePath)
        {
            var current_user = usersAdapter.GetData().FirstOrDefault(x => x.id == int.Parse(Properties.Settings.Default.userId));
            usersAdapter.UpdateQuery(current_user.surname, current_user.name, current_user.email, current_user.password,
                current_user.role, imagePath, current_user.id);
            Properties.Settings.Default.avatar = imagePath;
            Properties.Settings.Default.Save();
            App.WriteLog($"Пользователь {Properties.Settings.Default.userId} добавил новую аватарку");
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var current_user = usersAdapter.GetData().FirstOrDefault(x => x.id == int.Parse(Properties.Settings.Default.userId));
            usersAdapter.UpdateQuery(current_user.surname, current_user.name, current_user.email, current_user.password,
                current_user.role, @"C:\Users\paulscriptum\source\repos\AviaPlace\AviaPlace\imgs\avatar.png", current_user.id);
            App.WriteLog($"Пользователь {Properties.Settings.Default.userId} удалил аватарку");
            Properties.Settings.Default.avatar = @"C:\Users\paulscriptum\source\repos\AviaPlace\AviaPlace\imgs\avatar.png";
            Properties.Settings.Default.Save();
            AvatarImg.Source = new BitmapImage(new Uri(@"C:\Users\paulscriptum\source\repos\AviaPlace\AviaPlace\imgs\avatar.png"));
        }

        private void BackupBtn_Click(object sender, RoutedEventArgs e)
        {
            string selectedFileName = $"DB{DateTime.Now.Ticks}.bak";

            string backupDirectory = @"C:\Backup\";

            string backupFilePath = System.IO.Path.Combine(backupDirectory, System.IO.Path.GetFileName(selectedFileName));

            try
            {
                string backupCommand = $"BACKUP DATABASE AviaPlace TO DISK = '{backupFilePath}';";
                string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
                using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new System.Data.SqlClient.SqlCommand(backupCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                App.WriteLog($"Администратор {Properties.Settings.Default.userId} создал Backup базы данных");
                MessageBox.Show($"Backup успешно сохранен в путь восстановления");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:", ex.Message);
            }
        }

    }
}
