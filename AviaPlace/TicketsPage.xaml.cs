using AviaPlace.AviaPlaceDataSetTableAdapters;
using AviaPlace.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для TicketsPage.xaml
    /// </summary>
    public partial class TicketsPage : Page
    {
        AirportsTableAdapter airportsAdapter = new AirportsTableAdapter();
        AircraftTableAdapter aircraftAdapter = new AircraftTableAdapter();
        AirlinesTableAdapter airlinesAdapter = new AirlinesTableAdapter();
        FlightsTableAdapter flightsAdapter = new FlightsTableAdapter();
        TicketsTableAdapter ticketsAdapter = new TicketsTableAdapter();
        ReservationsTableAdapter reservationsAdapter = new ReservationsTableAdapter();
        SeatsAndClassesTableAdapter seatsAndClassesAdapter = new SeatsAndClassesTableAdapter();
        FlightsAndSeatsTableAdapter flightsAndSeatsAdapter = new FlightsAndSeatsTableAdapter();
        ClassesTableAdapter classesAdapter = new ClassesTableAdapter();
        QueriesTableAdapter queriesAdapter = new QueriesTableAdapter();
        private int statusId = 1;
        public TicketsPage()
        {
            InitializeComponent();
            queriesAdapter.UpdateReservationStatusIfFlightArrived(Convert.ToInt32(Settings.Default.userId));
            LoadTickets();
        }

        private void LoadTickets()
        {
            var userId = Convert.ToInt32(Settings.Default.userId);
            var reservationIds = reservationsAdapter.GetData()
                .Where(x => x.id_users == userId && x.id_statuse == statusId)
                .Select(x => x.id)
                .ToList();

            var ticketsForUser = ticketsAdapter.GetData()
                .Where(t => reservationIds.Contains(t.id_reservations))
                .Select(t => new { t.id_flightsAndSeats, t.id_reservations })
                .ToList();

            var fasForTickets = flightsAndSeatsAdapter.GetData()
                .Where(x => ticketsForUser.Select(t => t.id_flightsAndSeats).Contains(x.id))
                .Select(x => x.id_placesAndClasses)
                .ToList();

            var pacForUser = seatsAndClassesAdapter.GetData()
                .Where(x => fasForTickets.Contains(x.id))
                .Select(x => x.id_flight)
                .ToList();

            var flights = flightsAdapter.GetData()
                .Where(t => pacForUser.Contains(t.id))
                .ToList();

            var airports = airportsAdapter.GetData();
            var airlines = airlinesAdapter.GetData();
            var aircraft = aircraftAdapter.GetData();
            var seatsAndClasses = seatsAndClassesAdapter.GetData();
            var flightsAndSeats = flightsAndSeatsAdapter.GetData();
            var classes = classesAdapter.GetData();

            var flightControls = flights.Select(flight =>
            {
                var departureAirport = airports.FirstOrDefault(a => a.id == flight.airport_departure)?.name ?? "Unknown";
                var arrivalAirport = airports.FirstOrDefault(a => a.id == flight.airport_arrival)?.name ?? "Unknown";
                var airline = airlines.FirstOrDefault(al => al.id == flight.id_airlines)?.name ?? "Unknown";
                var model = aircraft.FirstOrDefault(ac => ac.id == flight.id_aircraft)?.model ?? "Unknown";
                var airlineImg = airlines.FirstOrDefault(al => al.id == flight.id_airlines)?.image ?? string.Empty;

                var departureDateTime = flight.departure_time.ToString("d MMM yyyy HH:mm");
                var arrivalDateTime = flight.arrival_time.ToString("d MMM yyyy HH:mm");

                var relevantSeatsAndClassesIds = seatsAndClasses.Where(s => s.id_flight == flight.id).Select(s => s.id).ToList();

                var flightsAndSeatsForFlight = flightsAndSeats
                    .Where(f => relevantSeatsAndClassesIds.Contains(f.id_placesAndClasses))
                    .ToList();

                var seatDetails = flightsAndSeatsForFlight
                    .Where(f => ticketsForUser.Any(t => t.id_flightsAndSeats == f.id))
                    .GroupBy(f => f.row)
                    .Select(group =>
                    {
                        var row = group.Key;
                        var places = string.Join(", ", group.Select(f => f.place).OrderBy(p => p));
                        var classInfo = seatsAndClasses.FirstOrDefault(sc => sc.id == group.FirstOrDefault()?.id_placesAndClasses);
                        var classText = classes.FirstOrDefault(x => x.id == classInfo?.id_class)?.name;
                        return row != null && classText != null ? $"{classText}: Ряд {row}, Место {places}" : null;
                    })
                    .Where(seatText => seatText != null)
                    .ToList();

                var flightControl = new TicketControl(flight, departureAirport, arrivalAirport, airline, model, airlineImg, seatDetails)
                {
                    DepartureTime = { Text = departureDateTime },
                    ArrivalTime = { Text = arrivalDateTime }
                };

                return flightControl;
            }).ToList();

            if (flightControls.Any())
            {
                FlightsList.ItemsSource = flightControls;
            }
            else
            {
                if (statusId == 1) FlightsList.ItemsSource = new List<string> { "У вас нет текущих рейсов! Скорее отправляйтесь в путешествие! :)" };
                else FlightsList.ItemsSource = new List<string> { "У вас нет завершенных рейсов!" };

            }
        }

        private void TicketsBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (statusId)
            {
                case 1:
                    NowTicketsBtn.Background = (Brush)Application.Current.Resources["LightGrey"];
                    ArchiveTicketsBtn.Background = (Brush)Application.Current.Resources["Important"];
                    statusId = 3;
                    break;
                case 3:
                    NowTicketsBtn.Background = (Brush)Application.Current.Resources["Important"];
                    ArchiveTicketsBtn.Background = (Brush)Application.Current.Resources["LightGrey"];
                    statusId = 1;
                    break;
            }
            LoadTickets();
        }
    }
}
