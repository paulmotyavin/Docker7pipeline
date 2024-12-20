using AviaPlace.AviaPlaceDataSetTableAdapters;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AviaPlace
{
    public partial class FlightDetailsPage : Page
    {
        private FlightsTableAdapter flightsAdapter = new FlightsTableAdapter();
        private AirportsTableAdapter airportsAdapter = new AirportsTableAdapter();
        private AirlinesTableAdapter airlinesAdapter = new AirlinesTableAdapter();
        private AircraftTableAdapter aircraftAdapter = new AircraftTableAdapter();
        private SeatsAndClassesTableAdapter sacAdapter = new SeatsAndClassesTableAdapter();
        private ClassesTableAdapter classesAdapter = new ClassesTableAdapter();
        private FlightsAndSeatsTableAdapter fasAdapter = new FlightsAndSeatsTableAdapter();

        private int flightId;
        private int airlineId;

        public FlightDetailsPage(int flightId)
        {
            InitializeComponent();
            this.flightId = flightId;
            LoadFlightDetails();
        }

        private void LoadFlightDetails()
        {
            var flight = flightsAdapter.GetData().FirstOrDefault(f => f.id == flightId);
            if (flight == null) return;

            airlineId = flight.id_airlines;

            FlightNumberText.Text = $"Рейс {flight.flight_number}";
            AirlineName.Text = airlinesAdapter.GetData().FirstOrDefault(a => a.id == flight.id_airlines)?.name ?? "Unknown";
            PlaneInfo.Text = $"{aircraftAdapter.GetData().FirstOrDefault(a => a.id == flight.id_aircraft)?.model ?? "Unknown"}, {aircraftAdapter.GetData().FirstOrDefault(a => a.id == flight.id_aircraft)?.capacity} мест";

            SetAirportDetails(DepartureAirport, flight.airport_departure);
            SetAirportDetails(ArrivalAirport, flight.airport_arrival);

            DepartureTime.Text = flight.departure_time.ToString("HH:mm dd MMMM yyyy");
            ArrivalTime.Text = flight.arrival_time.ToString("HH:mm dd MMMM yyyy");

            SetImage(AirlineLogo, airlinesAdapter.GetData().FirstOrDefault(a => a.id == flight.id_airlines)?.image);
            SetImage(AircraftImage, aircraftAdapter.GetData().FirstOrDefault(a => a.id == flight.id_aircraft)?.image);

            SetClassAndPriceDetails();
        }

        private void SetAirportDetails(TextBlock airportText, int airportId)
        {
            var airport = airportsAdapter.GetData().FirstOrDefault(a => a.id == airportId);
            airportText.Text = $"{airport?.name ?? "Unknown"} ({airport?.code ?? "XXX"})";
        }

        private void SetImage(Image imageControl, string imagePath)
        {
            imageControl.Source = new BitmapImage(new Uri(imagePath ?? "pack://application:,,,/imgs/placeholder.png", UriKind.Absolute));
        }

        private void SetClassAndPriceDetails()
        {
            ClearAndHidePanels(EconomyClassPanel, BusinessClassPanel, FirstClassPanel);

            foreach (var seatClass in sacAdapter.GetData().Where(sc => sc.id_flight == flightId))
            {
                var classDetails = classesAdapter.GetData().FirstOrDefault(c => c.id == seatClass.id_class);
                if (classDetails == null) continue;

                SetClassPanel(classDetails.name, seatClass.price);
            }
        }

        private void ClearAndHidePanels(params StackPanel[] panels)
        {
            foreach (var panel in panels)
            {
                panel.Children.Clear();
                panel.Visibility = Visibility.Collapsed;
            }
        }

        private void SetClassPanel(string className, decimal price)
        {
            StackPanel classPanel;
            string baggageInfo, description;

            switch (className)
            {
                case "Эконом":
                    classPanel = EconomyClassPanel;
                    baggageInfo = "1 место багажа до 23 кг";
                    description = "Идеальный выбор для тех, кто хочет комфорт по доступной цене. Путешествуйте с комфортом и экономией.";
                    break;
                case "Бизнес":
                    classPanel = BusinessClassPanel;
                    baggageInfo = "2 места багажа до 23 кг";
                    description = "Высокий уровень комфорта и обслуживания. Наслаждайтесь дополнительными привилегиями для спокойного полёта.";
                    break;
                case "Первый класс":
                    classPanel = FirstClassPanel;
                    baggageInfo = "3 места багажа до 23 кг";
                    description = "Эксклюзивные привилегии, максимальный комфорт и первоклассное обслуживание для незабываемого путешествия.";
                    break;
                default:
                    return;
            }

            classPanel.Visibility = Visibility.Visible;

            var classId = classesAdapter.GetData().FirstOrDefault(c => c.name == className)?.id;

            var seatClass = sacAdapter.GetData().FirstOrDefault(sc => sc.id_class == classId && sc.id_flight == flightId);

            if (seatClass == null)
            {
                return;
            }

            int totalSeats = seatClass.rows * seatClass.places;

            int occupiedSeats = fasAdapter.GetData()
                .Count(fs => fs.id_placesAndClasses == seatClass.id);

            int availableSeats = totalSeats - occupiedSeats;

            AddClassDetails(classPanel, className, description, price, baggageInfo, availableSeats);
        }

        private void AddClassDetails(StackPanel panel, string className, string description, decimal price, string baggageInfo, int availableSeats)
        {
            panel.Children.Add(CreateTextBlock(className, 22, FontWeights.Bold, "#333333"));
            panel.Children.Add(CreateTextBlock(description, 16, FontWeights.Normal, "#666666", TextWrapping.Wrap));
            panel.Children.Add(CreateTextBlock($"Цена: {(int)price} ₽", 20, FontWeights.SemiBold, "#FF5722"));
            panel.Children.Add(CreateTextBlock(baggageInfo, 16, FontWeights.Normal, "#808080"));
            panel.Children.Add(CreateTextBlock("Ручная кладь до 10 кг", 16, FontWeights.Normal, "#808080", margin: new Thickness(0, 5, 0, 15)));
            panel.Children.Add(CreateTextBlock($"Осталось мест: {availableSeats}", 16, FontWeights.Normal, "#808080"));
            panel.Children.Add(CreateButton("Купить", 120, 35, className));
        }



        private TextBlock CreateTextBlock(string text, double fontSize, FontWeight fontWeight, string colorHex, TextWrapping wrapping = TextWrapping.NoWrap, Thickness margin = default)
        {
            return new TextBlock
            {
                Text = text,
                FontSize = fontSize,
                FontWeight = fontWeight,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorHex)),
                HorizontalAlignment = HorizontalAlignment.Center,
                TextWrapping = wrapping,
                Margin = margin == default ? new Thickness(0, 5, 0, 5) : margin
            };
        }

        private Button CreateButton(string content, double width, double height, string className)
        {
            var button = new Button
            {
                Content = content,
                Width = width,
                Height = height,
                Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5722")),
                Foreground = Brushes.White,
                BorderBrush = Brushes.Transparent,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 10, 0, 0),
                Tag = className
            };

            button.Click += BuyBtn_Click;
            return button;
        }


        private void AirlineName_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClientWindow.pageFrame.Content = new AirlineInfoPage(airlineId);
            MessageBox.Show(airlineId.ToString());
        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string className)
            {
                ClientWindow.pageFrame.Content = new SeatsPage(flightId, Convert.ToInt32(Properties.Settings.Default.userId), className);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}
