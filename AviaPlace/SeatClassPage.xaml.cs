using AviaPlace.AviaPlaceDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для SeatClassPage.xaml
    /// </summary>
    public partial class SeatClassPage : Page
    {
        ClassesTableAdapter classAdapter = new ClassesTableAdapter();
        FlightsTableAdapter flightsAdapter = new FlightsTableAdapter();
        AircraftTableAdapter aircraftAdapter = new AircraftTableAdapter();
        SeatsAndClassesTableAdapter sacAdapter = new SeatsAndClassesTableAdapter();
        private int capacity = 0;
        private int occupiedSeats = 0;
        public SeatClassPage()
        {
            InitializeComponent();

            ClassCbx.ItemsSource = classAdapter.GetData();
            ClassCbx.DisplayMemberPath = "name";
            ClassCbx.SelectedValuePath = "id";

            FlightCbx.ItemsSource = flightsAdapter.GetData();
            FlightCbx.DisplayMemberPath = "flight_number";
            FlightCbx.SelectedValuePath = "id";

            LeftPlaces();
            LoadSeatClasses();
        }

        private void RowsTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                string currentText = textBox.Text + e.Text;

                if (currentText.Length == 1 && currentText == "0" || !System.Text.RegularExpressions.Regex.IsMatch(e.Text, @"^\d$"))
                {
                    e.Handled = true;
                }
            }
        }

        private void ItemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemsList.SelectedItem is SeatClassControl sc)
            {
                RowsTbx.Text = sc.Rows.ToString();
                PlacesTbx.Text = sc.Places.ToString();
                PriceTbx.Text = sc.Price.ToString();
                ClassCbx.Text = sc.Class;
                FlightCbx.Text = sc.Flight;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields("add"))
            {
                sacAdapter.InsertQuery(Convert.ToInt32(RowsTbx.Text), Convert.ToInt32(PlacesTbx.Text), Convert.ToInt32(PriceTbx.Text),
                    Convert.ToInt32(ClassCbx.SelectedValue), Convert.ToInt32(FlightCbx.SelectedValue));
                App.WriteLog($"Добавлена новая запись в таблицу \"SeatsAndClasses\"");
                Clear();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsList.SelectedItem is SeatClassControl selectedSC && ValidateFields("edit"))
            {
                sacAdapter.UpdateQuery(Convert.ToInt32(RowsTbx.Text), Convert.ToInt32(PlacesTbx.Text), Convert.ToInt32(PriceTbx.Text),
                    Convert.ToInt32(ClassCbx.SelectedValue), Convert.ToInt32(FlightCbx.SelectedValue), selectedSC.id);
                App.WriteLog($"Изменена {selectedSC.id} запись в таблице \"SeatsAndClasses\"");
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsList.SelectedItem is SeatClassControl selectedSC)
            {
                sacAdapter.DeleteQuery(selectedSC.id);
                App.WriteLog($"Удалена {selectedSC.id} запись из таблицы \"SeatsAndClasses\"");
                Clear();
            }
            else MessageBox.Show("Выберите авиакомпанию для удаления");
        }

        private void FlightCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FlightCbx.SelectedValue != null)
            {
                var flight = flightsAdapter.GetData().First(x => x.id == Convert.ToInt32(FlightCbx.SelectedValue));
                var aircraft = aircraftAdapter.GetData().First(x => x.id == flight.id_aircraft);
                capacity = aircraft.capacity;
                LeftPlaces();
            }
            
        }

        private bool ValidateFields(string action)
        {
            if (string.IsNullOrWhiteSpace(RowsTbx.Text) || string.IsNullOrWhiteSpace(PlacesTbx.Text) ||
                string.IsNullOrWhiteSpace(PriceTbx.Text) || string.IsNullOrWhiteSpace(ClassCbx.Text) ||
                string.IsNullOrWhiteSpace(FlightCbx.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return false;
            }

            var selectedClassId = Convert.ToInt32(ClassCbx.SelectedValue);
            var selectedFlightId = Convert.ToInt32(FlightCbx.SelectedValue);

            if (action != "edit")
            {
                if (sacAdapter.GetData().Any(x => x.id_class == selectedClassId && x.id_flight == selectedFlightId))
                {
                    MessageBox.Show("Данный класс уже занят для этого рейса.");
                    return false;
                }
            }
            else
            {
                var selectedItem = ItemsList.SelectedItem as SeatClassControl;
                if (selectedItem != null)
                {
                    var existingClass = sacAdapter.GetData().FirstOrDefault(x =>
                        x.id_class == selectedClassId && x.id_flight == selectedFlightId && x.id != selectedItem.id);
                    if (existingClass != null)
                    {
                        MessageBox.Show("Данный класс уже занят для этого рейса.");
                        return false;
                    }
                }
            }

            if (occupiedSeats > capacity)
            {
                MessageBox.Show($"Выбранные ряды и места не должны превышать вместимость самолета ({capacity})");
                return false;
            }

            return true;
        }


        private void Clear()
        {
            RowsTbx.Clear();
            PlacesTbx.Clear();
            PriceTbx.Clear();
            ClassCbx.SelectedItem = null;
            FlightCbx.SelectedItem = null;
            LoadSeatClasses();
        }

        private void LoadSeatClasses()
        {
            var seatClasses = sacAdapter.GetData();
            var classes = classAdapter.GetData();
            var flights = flightsAdapter.GetData();

            var seatClassControls = new List<SeatClassControl>();

            foreach (var seatClass in seatClasses)
            {
                var Class = classes.FirstOrDefault(a => a.id == seatClass.id_class)?.name ?? "Unknown";
                var Flight = flights.FirstOrDefault(a => a.id == seatClass.id_flight)?.flight_number ?? "Unknown";

                var flightControl = new SeatClassControl(seatClass, Flight, Class);

                seatClassControls.Add(flightControl);
            }

            ItemsList.ItemsSource = seatClassControls;
        }

        private void RowsPlacesTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            LeftPlaces();
        }

        private void LeftPlaces()
        {
            if (!string.IsNullOrEmpty(RowsTbx.Text) && !string.IsNullOrEmpty(PlacesTbx.Text) && FlightCbx.SelectedValue != null)
            {
                int left = Convert.ToInt32(RowsTbx.Text) * Convert.ToInt32(PlacesTbx.Text);
                var selectedFlightId = Convert.ToInt32(FlightCbx.SelectedValue);

                var seatClassesForFlight = sacAdapter.GetData().Where(sc => sc.id_flight == selectedFlightId).ToList();

                occupiedSeats = seatClassesForFlight.Sum(sc => sc.rows * sc.places) + left;

                RowsLeftTbk.Text = $"Мест: {occupiedSeats} из {capacity}";
            } else if (FlightCbx.SelectedValue != null)
            {
                var selectedFlightId = Convert.ToInt32(FlightCbx.SelectedValue);
                var seatClassesForFlight = sacAdapter.GetData().Where(sc => sc.id_flight == selectedFlightId).ToList();
                occupiedSeats = seatClassesForFlight.Sum(sc => sc.rows * sc.places);

                RowsLeftTbk.Text = $"Мест: {occupiedSeats} из {capacity}";
            }
        }
    }
}
