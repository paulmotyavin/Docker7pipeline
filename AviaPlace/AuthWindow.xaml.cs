using AviaPlace.AviaPlaceDataSetTableAdapters;
using System.Windows;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        UsersTableAdapter usersAdapter = new UsersTableAdapter();

        public AuthWindow()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.userId))
            {
                switch (Properties.Settings.Default.role)
                {
                    case "Администратор":
                        new AdminWindow().Show();
                        this.Close();
                        break;
                    case "Клиент":
                        new ClientWindow().Show();
                        this.Close();
                        break;
                }
            }
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            RegWindow reg = new RegWindow();
            reg.Show();
            this.Close();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            var logData = usersAdapter.GetData();
            bool isLogged = false;
            foreach (var data in logData)
            {
                if (data.email == loginTbx.Text && data.password == App.sha256(passwordTbx.Password))
                {
                    Properties.Settings.Default.userId = data.id.ToString();
                    Properties.Settings.Default.avatar = data.avatar;
                    Properties.Settings.Default.role = data.role;
                    Properties.Settings.Default.Save();
                    switch (data.role)
                    {
                        case "Администратор":
                            App.WriteLog($"Пользователь с почтой {data.email} был авторизован как Администратор");
                            AdminWindow adminWindow = new AdminWindow();
                            adminWindow.Show();
                            this.Close();
                            break;
                        case "Клиент":
                            App.WriteLog($"Пользователь с почтой {data.email} был авторизован как Клиент");
                            ClientWindow clientWindow = new ClientWindow();
                            clientWindow.Show();
                            this.Close();
                            break;
                    }
                    isLogged = true;
                    break;
                }
            }
            if (!isLogged) MessageBox.Show("Неверный логин или пароль!");
        }
    }
}
