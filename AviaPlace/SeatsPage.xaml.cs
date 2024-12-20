using AviaPlace.AviaPlaceDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AviaPlace
{
    public partial class SeatsPage : Page
    {
        private SeatsAndClassesTableAdapter sacAdapter = new SeatsAndClassesTableAdapter();
        private ClassesTableAdapter classesAdapter = new ClassesTableAdapter();
        private FlightsAndSeatsTableAdapter flightsAndSeatsAdapter = new FlightsAndSeatsTableAdapter();
        private ReservationsTableAdapter reservationsAdapter = new ReservationsTableAdapter();
        private TicketsTableAdapter ticketsAdapter = new TicketsTableAdapter();
        private int flightId;
        private int userId;
        private int classId;
        private int sacId;
        private List<(int row, int seatNum)> SelectedSeats = new List<(int, int)>();
        private decimal priceClass = 0;

        public SeatsPage(int flightId, int userId, string className)
        {
            InitializeComponent();
            this.flightId = flightId;
            this.userId = userId;
            classId = classesAdapter.GetData().FirstOrDefault(x => x.name == className).id;
            LoadSeatLayout();
        }

        private void LoadSeatLayout()
        {
            var seatClassConfig = sacAdapter.GetData().FirstOrDefault(s => s.id_flight == flightId && s.id_class == classId);
            sacId = seatClassConfig.id;
            if (seatClassConfig == null)
            {
                MessageBox.Show("Seat configuration not found for this flight.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            priceClass = seatClassConfig.price;
            int rows = seatClassConfig.rows;
            int seatsPerRow = seatClassConfig.places;

            SeatGrid.Rows = rows;
            SeatGrid.Columns = seatsPerRow;

            var reservedSeats = flightsAndSeatsAdapter.GetData()
                                                        .Where(fs => fs.id_placesAndClasses == sacId)
                                                        .Select(fs => new { fs.row, fs.place })
                                                        .ToList();

            for (int row = 1; row <= rows; row++)
            {
                for (int seatNum = 1; seatNum <= seatsPerRow; seatNum++)
                {
                    var seatButton = CreateSeatButton(row, seatNum);

                    if (reservedSeats.Any(rs => rs.row == row && rs.place == seatNum))
                    {
                        seatButton.Background = Brushes.Gray;
                        seatButton.IsEnabled = false;
                    }
                    else
                    {
                        seatButton.Background = Brushes.Green;
                        seatButton.IsEnabled = true;
                    }

                    SeatGrid.Children.Add(seatButton);
                }
            }
        }

        private Button CreateSeatButton(int row, int seatNum)
        {
            var seatButton = new Button
            {
                Content = $"{row}{(char)('A' + seatNum - 1)}",
                Width = 150,
                Height = 70,
                FontSize = 18,
                Margin = new Thickness(10),
                Tag = (row, seatNum),
                Background = Brushes.Green,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            seatButton.Click += SeatButton_Click;
            return seatButton;
        }

        private void SeatButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var (row, seatNum) = ((int, int))button.Tag;

            if (button.Background == Brushes.Green)
            {
                button.Background = Brushes.Orange;
                SelectedSeats.Add((row, seatNum));
            }
            else if (button.Background == Brushes.Orange)
            {
                button.Background = Brushes.Green;
                SelectedSeats.Remove((row, seatNum));
            }
            UpdateTextBlock();
        }

        private void ConfirmPurchase_Click(object sender, RoutedEventArgs e)
        {
            if (!SelectedSeats.Any())
            {
                MessageBox.Show("Нет выбранных мест! Выберите места.");
                return;
            }

            reservationsAdapter.InsertQuery(userId, DateTime.Now, 1);
            App.WriteLog($"Появилось новое бронирование пользователем {userId}");
            int reservationId = (int)reservationsAdapter.ScalarQuery();
            foreach (var (row, seatNum) in SelectedSeats)
            {
                flightsAndSeatsAdapter.InsertQuery(sacId, priceClass * SelectedSeats.Count, row, seatNum);
                App.WriteLog($"Совершена покупа на сумму {priceClass * SelectedSeats.Count}, {row} ряд и {seatNum} место");
                var seatId = (int)flightsAndSeatsAdapter.ScalarQuery();

                ticketsAdapter.InsertQuery(reservationId, seatId);
            }

            MessageBox.Show("Успешная покупка!");
            ClientWindow.pageFrame.Content = new FlightDetailsPage(flightId);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void UpdateTextBlock()
        {
            PriceTbk.Text = $"{(int)priceClass * SelectedSeats.Count} ₽";
        }
    }
}
