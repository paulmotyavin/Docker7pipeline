using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для TicketControl.xaml
    /// </summary>
    public partial class TicketControl : UserControl
    {
        public int id { get; set; }
        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }
        public string departureAirport { get; set; }
        public string arrivalAirport { get; set; }
        public string duration { get; set; }
        public string airline { get; set; }
        public string flight { get; set; }

        public string model { get; set; }
        public string airlineImg { get; set; }
        public string classInfo { get; set; }
        public List<string> seatInfoPanel { get; set; }


        public TicketControl(AviaPlaceDataSet.FlightsRow flight, string departureAirport, string arrivalAirport, string airline, string model, string airlineImg, List<string> seats)
        {
            InitializeComponent();
            id = flight.id;
            departureTime = flight.departure_time;
            arrivalTime = flight.arrival_time;
            this.departureAirport = departureAirport;
            this.arrivalAirport = arrivalAirport;
            this.airline = airline;
            this.model = model;
            this.airlineImg = airlineImg;
            this.flight = flight.flight_number.ToString();
            duration = CalculateDuration(departureTime, arrivalTime);
            seatInfoPanel = seats;
            DepartureTime.Text = departureTime.ToString("HH:mm");
            ArrivalTime.Text = arrivalTime.ToString("HH:mm");
            Duration.Text = duration;
            Name.Text = airline;
            ModelTbx.Text = model;
            Flight.Text = this.flight;
            AirlineImage.Source = new BitmapImage(new Uri(airlineImg));
            foreach (var seat in seatInfoPanel)
            {
                SeatInfoPanel.Children.Add(new TextBlock { Text = seat, FontSize = 12, Foreground = new SolidColorBrush(Colors.Black) });
            }

        }

        private string CalculateDuration(DateTime departureTime, DateTime arrivalTime)
        {
            TimeSpan difference = arrivalTime - departureTime;
            return difference.Days > 0
                ? $"{difference.Days} д {difference.Hours} ч {difference.Minutes} мин"
                : $"{difference.Hours} ч {difference.Minutes} мин";
        }
    }
}
