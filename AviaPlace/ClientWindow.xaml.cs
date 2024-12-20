using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public static Frame pageFrame;
        private ListBoxItem previous = null;
        private bool isPaused = false;

        public ClientWindow()
        {
            InitializeComponent();
            var flightsItem = NavigationList.Items.Cast<ListBoxItem>().FirstOrDefault(item => item.Name == "FlightsItem");
            flightsItem.IsSelected = true;
            LottieAnim.PlayAnimation();
            pageFrame = PageFrame;
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
                        PageFrame.Content = new UserFlightsPage();
                        break;
                    case "TicketsItem":
                        PageFrame.Content = new TicketsPage();
                        break;
                    case "ReviewsItem":
                        PageFrame.Content = new ReviewsPage();
                        break;

                    default:
                        PageFrame.Content = new ProfilePage(this);
                        break;
                }
                previous = lbi;
            }
        }

        private void LottieAnim_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isPaused)
            {
                LottieAnim.StopAnimation();
                isPaused = false;
            }
            else
            {
                LottieAnim.PlayAnimation();
                isPaused = true;
            }
        }
    }
}
