using AviaPlace.AviaPlaceDataSetTableAdapters;
using System;
using System.Linq;
using System.Windows.Controls;

namespace AviaPlace
{
    public partial class UserFlightsPage : Page
    {
        AirportsTableAdapter airportsAdapter = new AirportsTableAdapter();
        AircraftTableAdapter aircraftAdapter = new AircraftTableAdapter();
        AirlinesTableAdapter airlinesAdapter = new AirlinesTableAdapter();
        FlightsTableAdapter flightsAdapter = new FlightsTableAdapter();
        SeatsAndClassesTableAdapter sacAdapter = new SeatsAndClassesTableAdapter();

        public UserFlightsPage()
        {
            InitializeComponent();

            FindDeparture.ItemsSource = airportsAdapter.GetData();
            FindDeparture.DisplayMemberPath = "name";
            FindDeparture.SelectedValuePath = "code";

            FindArrival.ItemsSource = airportsAdapter.GetData();
            FindArrival.DisplayMemberPath = "name";
            FindArrival.SelectedValuePath = "code";

            LoadFlights();
        }

        private void LoadFlights()
        {
            var airports = airportsAdapter.GetData();
            var aircraft = aircraftAdapter.GetData();
            var airlines = airlinesAdapter.GetData();
            var flights = flightsAdapter.GetData().Where(f => f.departure_time > DateTime.Now);
            var sacs = sacAdapter.GetData();

            var flightControls = flights.Select(flight =>
            {
                var departureAirport = airports.FirstOrDefault(a => a.id == flight.airport_departure)?.code ?? "Unknown";
                var arrivalAirport = airports.FirstOrDefault(a => a.id == flight.airport_arrival)?.code ?? "Unknown";
                var airline = airlines.FirstOrDefault(al => al.id == flight.id_airlines)?.name ?? "Unknown";
                var model = aircraft.FirstOrDefault(ac => ac.id == flight.id_aircraft)?.model ?? "Unknown";
                var minPrice = (int) sacs.Where(ac => ac.id_flight == flight.id).Select(ac => ac.price).DefaultIfEmpty().Min();
                var duration = flight.arrival_time - flight.departure_time;
                return new { flight, departureAirport, arrivalAirport, airline, model, minPrice, duration };
            })
            .Where(f =>
                (string.IsNullOrEmpty(FindFlight.Text) || f.flight.flight_number.Contains(FindFlight.Text)) &&
                (FindDeparture.SelectedValue == null || f.departureAirport == FindDeparture.SelectedValue.ToString()) &&
                (FindArrival.SelectedValue == null || f.arrivalAirport == FindArrival.SelectedValue.ToString()) &&
                (string.IsNullOrEmpty(PriceAfter.Text) || f.minPrice >= Convert.ToInt32(PriceAfter.Text)) &&
                (string.IsNullOrEmpty(PriceBefore.Text) || f.minPrice <= Convert.ToInt32(PriceBefore.Text)) &&
                (DepartureDatePicker.SelectedDate == null || f.flight.departure_time.Date == DepartureDatePicker.SelectedDate.Value.Date)
            );

            switch (SortComboBox.SelectedIndex)
            {
                case 0:
                    flightControls = flightControls.OrderBy(f => f.minPrice);
                    break;
                case 1:
                    flightControls = flightControls.OrderByDescending(f => f.minPrice);
                    break;
                case 2:
                    flightControls = flightControls.OrderBy(f => f.duration);
                    break;
                case 3:
                    flightControls = flightControls.OrderByDescending(f => f.duration);
                    break;
                default:
                    break;
            }

            var userFlightControls = flightControls.Select(f => new UserFlightControl(
                f.flight,
                f.departureAirport,
                f.arrivalAirport,
                f.airline,
                f.model,
                airlines.FirstOrDefault(al => al.id == f.flight.id_airlines)?.image ?? string.Empty,
                f.minPrice.ToString()
            )).ToList();

            FlightsList.ItemsSource = userFlightControls;
        }

        private void FindFlight_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadFlights();
        }

        private void FindDeparture_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadFlights();
        }

        private void FindArrival_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadFlights();
        }

        private void PriceAfter_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadFlights();
        }

        private void PriceBefore_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadFlights();
        }

        private void DepartureDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadFlights();
        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadFlights();
        }

        private void FlightsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FlightsList.SelectedItem = null;
        }
    }
}
