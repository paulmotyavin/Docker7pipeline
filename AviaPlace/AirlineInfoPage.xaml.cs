using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using AviaPlace.AviaPlaceDataSetTableAdapters;
using AviaPlace.Properties;

namespace AviaPlace
{
    public partial class AirlineInfoPage : Page
    {
        private int airlineId;
        AirlinesTableAdapter airlinesAdapter = new AirlinesTableAdapter();
        FlightsTableAdapter flightsAdapter = new FlightsTableAdapter();
        AirportsTableAdapter airportsAdapter = new AirportsTableAdapter();
        AircraftTableAdapter aircraftAdapter = new AircraftTableAdapter();
        SeatsAndClassesTableAdapter sacAdapter = new SeatsAndClassesTableAdapter();
        ReviewsTableAdapter reviewsAdapter = new ReviewsTableAdapter();
        UsersTableAdapter usersAdapter = new UsersTableAdapter();

        public AirlineInfoPage(int airlineId)  // Передаем id авиакомпании
        {
            this.airlineId = airlineId;
            InitializeComponent();
            LoadAirlineData(airlineId);
            LoadCurrentFlights(airlineId);
            LoadReviews();
        }

        private void LoadReviews()
        {
            var reviews = reviewsAdapter.GetData().Where(x => x.id_airlines == airlineId);
            var reviewsList = new List<ReviewControl>();
            foreach (var r in reviews)
            {
                var user = usersAdapter.GetData().FirstOrDefault(x => x.id == r.id_users);
                var reviewControl = new ReviewControl(r, user);
                reviewsList.Add(reviewControl);
            }
            ReviewsList.ItemsSource = reviewsList;
        }

        // Загружаем информацию об авиакомпании
        private void LoadAirlineData(int airlineId)
        {
            var airline = airlinesAdapter.GetData().FirstOrDefault(a => a.id == airlineId);
            if (airline != null)
            {
                AirlineName.Text = airline.name;
                AirlineCity.Text = airline.country;
                AirlineLogo.Source = new BitmapImage(new Uri(airline.image));  // Замените на правильный путь к изображению
                AirlineRating.Text = CalculateAirlineRating(airlineId).ToString();
            }
        }

        // Рассчитываем средний рейтинг авиакомпании
        private double CalculateAirlineRating(int airlineId)
        {
            var reviews = reviewsAdapter.GetData().Where(r => r.id_airlines == airlineId);
            if (!reviews.Any()) return 0;

            return reviews.Average(r => r.rating);
        }

        // Загружаем текущие рейсы для выбранной авиакомпании
        private void LoadCurrentFlights(int airlineId)
        {
            var airports = airportsAdapter.GetData();
            var aircraft = aircraftAdapter.GetData();
            var airlines = airlinesAdapter.GetData();
            var flights = flightsAdapter.GetData().Where(f => f.id_airlines == airlineId && f.departure_time > DateTime.Now).ToList();
            var sacs = sacAdapter.GetData();

            var flightControls = flights.Select(flight =>
            {
                var departureAirport = airports.FirstOrDefault(a => a.id == flight.airport_departure)?.code ?? "Unknown";
                var arrivalAirport = airports.FirstOrDefault(a => a.id == flight.airport_arrival)?.code ?? "Unknown";
                var airline = airlines.FirstOrDefault(al => al.id == flight.id_airlines)?.name ?? "Unknown";
                var model = aircraft.FirstOrDefault(ac => ac.id == flight.id_aircraft)?.model ?? "Unknown";
                var minPrice = (int)sacs.Where(ac => ac.id_flight == flight.id).Select(ac => ac.price).DefaultIfEmpty().Min();
                var duration = flight.arrival_time - flight.departure_time;

                return new
                {
                    flight,
                    departureAirport,
                    arrivalAirport,
                    airline,
                    model,
                    minPrice,
                    duration
                };
            }).ToList();

            // Преобразуем рейсы в UserFlightControl
            var userFlightControls = flightControls.Select(f => new UserFlightControl(
                f.flight,
                f.departureAirport,
                f.arrivalAirport,
                f.airline,
                f.model,
                airlines.FirstOrDefault(al => al.id == f.flight.id_airlines)?.image ?? string.Empty,
                f.minPrice.ToString()
            )).ToList();

            if (userFlightControls.Any())
                CurrentFlightsList.ItemsSource = userFlightControls;
            else CurrentFlightsList.Items.Add("В настоящее время рейсов нет");
        }

        // Обработчик изменения выбранного элемента в списке рейсов
        private void CurrentFlightsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentFlightsList.SelectedItem = null;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SubmitReviewButton_Click(object sender, RoutedEventArgs e)
        {
            string reviewText = ReviewTextBox.Text;
            string rating = (RatingComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (!string.IsNullOrEmpty(reviewText) && !string.IsNullOrEmpty(rating))
            {
                reviewsAdapter.Insert(Convert.ToInt32(Settings.Default.userId), airlineId, Convert.ToInt32(rating.Substring(0,1)), reviewText, DateTime.Now);
                ReviewTextBox.Clear();
                RatingComboBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }
    }
}