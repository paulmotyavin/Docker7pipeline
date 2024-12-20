using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private ListBoxItem previous = null;

        public AdminWindow()
        {
            InitializeComponent();
            var flightsItem = NavigationList.Items.Cast<ListBoxItem>().FirstOrDefault(item => item.Name == "FlightsItem");
            flightsItem.IsSelected = true;
        }

        // Событие закрытия окна
        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        // События сворачивания окна

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        // Событие выбора страницы
        private void OnSelected(object sender, RoutedEventArgs e)
        {
            ListBoxItem lbi = e.Source as ListBoxItem;
            if (lbi != null)
            {
                if (previous != null && (previous.Name == "ProfileItem" || lbi.Name == "ProfileItem"))
                {
                    previous.IsSelected = false;
                }
                // Выбор открытия страницы в зависимости от нажатого элемента
                switch (lbi.Name)
                {
                    case "FlightsItem":
                        PageFrame.Content = new FlightsPage();
                        break;
                    case "AirportsItem":
                        PageFrame.Content = new AirportsPage();
                        break;
                    case "UsersItem":
                        PageFrame.Content = new UsersPage();
                        break;
                    case "AirlinesItem":
                        PageFrame.Content = new AirlinesPage();
                        break;
                    case "PlanesItem":
                        PageFrame.Content = new PlanesPage();
                        break;
                    case "StatsItem":
                        PageFrame.Content = new StatisticsPage();
                        break;
                    case "SeatsClassItem":
                        PageFrame.Content = new SeatClassPage();
                        break;
                    case "ReviewsItem":
                        PageFrame.Content = new ReviewsPage();
                        break;
                    case "LogsItem":
                        PageFrame.Content = new LoggingPage();
                        break;
                    default:
                        PageFrame.Content = new ProfilePage(this);
                        break;
                }
                previous = lbi;
            }
        }
    }
}
