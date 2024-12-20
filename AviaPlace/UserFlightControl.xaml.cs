using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для UserFlightControl.xaml
    /// </summary>
    public partial class UserFlightControl : UserControl
    {
        public int id { get; set; }
        public int airlineId {  get; set; }

        public UserFlightControl(AviaPlaceDataSet.FlightsRow flight, string DepartureAirport,
            string ArrivalAirport, string airline, string model, string airlineImg, string price)
        {
            InitializeComponent();
            id = flight.id;
            airlineId = flight.id_airlines;
            string Duration = CalculateDuration(flight.departure_time, flight.arrival_time);

            departureTime.Text = flight.departure_time.ToString("HH:mm");
            arrivalTime.Text = flight.arrival_time.ToString("HH:mm");
            duration.Text = Duration;
            nameTbx.Text = airline;
            modelTbx.Text = model;
            flightTbx.Text = flight.flight_number.ToString();
            arrivalAirport.Text = ArrivalAirport;
            departureAirport.Text = DepartureAirport;
            airlineImage.Source = new BitmapImage(new Uri(airlineImg));
            priceTbx.Text = $"от {price} ₽";
        }

        private string CalculateDuration(DateTime departureTime, DateTime arrivalTime)
        {
            TimeSpan difference = arrivalTime - departureTime;
            return difference.Days > 0
                ? $"{difference.Days} д {difference.Hours} ч {difference.Minutes} мин"
                : $"{difference.Hours} ч {difference.Minutes} мин";
        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            FlightDetailsPage page = new FlightDetailsPage(id);
            ClientWindow.pageFrame.Content = page;
        }

        private void nameTbx_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClientWindow.pageFrame.Content = new AirlineInfoPage(airlineId);
        }
    }
}
