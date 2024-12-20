using AviaPlace.AviaPlaceDataSetTableAdapters;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для FlightsPage.xaml
    /// </summary>
    public partial class FlightsPage : Page
    {
        private string activeField = "";
        AirportsTableAdapter airportsAdapter = new AirportsTableAdapter();
        AircraftTableAdapter aircraftAdapter = new AircraftTableAdapter();
        AirlinesTableAdapter airlinesAdapter = new AirlinesTableAdapter();
        FlightsTableAdapter flightsAdapter = new FlightsTableAdapter();
        public FlightsPage()
        {
            InitializeComponent();
            Calendar.Language = XmlLanguage.GetLanguage(System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag);

            DepartureCbx.ItemsSource = airportsAdapter.GetData();
            DepartureCbx.SelectedValuePath = "id";
            DepartureCbx.DisplayMemberPath = "name";

            ArrivalCbx.ItemsSource = airportsAdapter.GetData();
            ArrivalCbx.SelectedValuePath = "id";
            ArrivalCbx.DisplayMemberPath = "name";

            AircraftCbx.ItemsSource = aircraftAdapter.GetData();
            AircraftCbx.SelectedValuePath = "id";
            AircraftCbx.DisplayMemberPath = "model";

            AirlinesCbx.ItemsSource = airlinesAdapter.GetData();
            AirlinesCbx.SelectedValuePath = "id";
            AirlinesCbx.DisplayMemberPath = "name";

            LoadFlights();
        }

        private void LoadFlights()
        {
            var airports = airportsAdapter.GetData();
            var aircraft = aircraftAdapter.GetData();
            var airlines = airlinesAdapter.GetData();
            var flights = flightsAdapter.GetData();

            var flightControls = new List<FlightControl>();

            foreach (var flight in flights)
            {
                var departureAirport = airports.FirstOrDefault(a => a.id == flight.airport_departure)?.name ?? "Unknown";
                var arrivalAirport = airports.FirstOrDefault(a => a.id == flight.airport_arrival)?.name ?? "Unknown";

                var airline = airlines.FirstOrDefault(al => al.id == flight.id_airlines)?.name ?? "Unknown";
                var model = aircraft.FirstOrDefault(ac => ac.id == flight.id_aircraft)?.model ?? "Unknown";

                var airlineImg = airlines.FirstOrDefault(al => al.id == flight.id_airlines)?.image ?? string.Empty;

                var flightControl = new FlightControl(flight, departureAirport, arrivalAirport, airline, model, airlineImg);

                flightControls.Add(flightControl);
            }

            FlightsList.ItemsSource = flightControls;
        }

        private void FlightsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FlightsList.SelectedItem is FlightControl flight)
            {
                NumberTbx.Text = flight.flight;
                DepartureCbx.Text = flight.departureAirport;
                ArrivalCbx.Text = flight.arrivalAirport;
                dtTbx.Text = flight.departureTime.ToString();
                dtTbx1.Text = flight.arrivalTime.ToString();
                AircraftCbx.Text = flight.model;
                AirlinesCbx.Text = flight.airline;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                if (DateTime.Parse(dtTbx1.Text) > DateTime.Parse(dtTbx.Text))
                {
                    flightsAdapter.InsertQuery(NumberTbx.Text, Convert.ToInt32(DepartureCbx.SelectedValue), Convert.ToInt32(ArrivalCbx.SelectedValue), DateTime.Parse(dtTbx.Text), DateTime.Parse(dtTbx1.Text),
                    Convert.ToInt32(AircraftCbx.SelectedValue), Convert.ToInt32(AirlinesCbx.SelectedValue));
                    App.WriteLog($"Добавлен новый рейс - {NumberTbx.Text}");
                    Clear();
                }
                else MessageBox.Show("Время прилета не может быть раньше времени вылета");
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (FlightsList.SelectedItem is FlightControl selectedFlight && ValidateFields())
            {
                flightsAdapter.UpdateQuery(NumberTbx.Text, Convert.ToInt32(DepartureCbx.SelectedValue), Convert.ToInt32(ArrivalCbx.SelectedValue), DateTime.Parse(dtTbx.Text), DateTime.Parse(dtTbx1.Text),
                Convert.ToInt32(AircraftCbx.SelectedValue), Convert.ToInt32(AirlinesCbx.SelectedValue), selectedFlight.id);
                App.WriteLog($"Изменен рейс с идентификатором {selectedFlight.id}");
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (FlightsList.SelectedItem is FlightControl selectedFlight)
            {
                flightsAdapter.DeleteQuery(selectedFlight.id);
                App.WriteLog($"Рейс {selectedFlight.flight} с идентификатором {selectedFlight.id} был удален");
                Clear();
            }
            else MessageBox.Show("Выберите рейс для удаления");
        }

        private void DateTimeBtn_Click(object sender, RoutedEventArgs e)
        {
            DatePickerDialogHost.IsOpen = true;
            Calendar.SelectedDate = DateTime.Now;
            Clock.Time = DateTime.Now;
            if (sender == dtBtn) activeField = "dt";
            else activeField = "dt1";
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            var date = Calendar.SelectedDate;
            var selectedTime = Clock.Time;
            var nowDate = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, selectedTime.Hour, selectedTime.Minute, selectedTime.Second);
            if (nowDate > DateTime.Now)
            {
                
                if (activeField == "dt") dtTbx.Text = $"{date.Value.Date.ToShortDateString()} {selectedTime.Hour:D2}:{selectedTime.Minute:D2}";
                else dtTbx1.Text = $"{date.Value.Date.ToShortDateString()} {selectedTime.Hour:D2}:{selectedTime.Minute:D2}";

                DatePickerDialogHost.IsOpen = false;
            }
            else
            {
                if (activeField == "dt") HintAssist.SetHint(dtTbx, "Время вылета");
                else HintAssist.SetHint(dtTbx1, "Время прилета");
            }
        }

        public bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(NumberTbx.Text) || string.IsNullOrWhiteSpace(DepartureCbx.Text) ||
                string.IsNullOrWhiteSpace(ArrivalCbx.Text) || string.IsNullOrWhiteSpace(dtTbx.Text) || string.IsNullOrWhiteSpace(dtTbx1.Text) ||
                string.IsNullOrWhiteSpace(AircraftCbx.Text) || string.IsNullOrWhiteSpace(AirlinesCbx.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return false;
            }

            int validation = 0;
            string nameP = @"^[A-Z]{2}\d{1,4}$";
            if (Regex.IsMatch(NumberTbx.Text, nameP)) validation++;
            else MessageBox.Show("Неверный формат номера рейса. Пример: SU1234 или SU1234");

            return validation == 1;
        }

        private void Clear()
        {
            NumberTbx.Clear();
            DepartureCbx.SelectedItem = null;
            ArrivalCbx.SelectedItem = null;
            dtTbx.Clear();
            dtTbx1.Clear();
            AircraftCbx.SelectedItem = null;
            AirlinesCbx.SelectedItem = null;
            LoadFlights();
        }
    }
}
