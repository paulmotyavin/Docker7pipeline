using AviaPlace.AviaPlaceDataSetTableAdapters;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для PlanesPage.xaml
    /// </summary>
    public partial class PlanesPage : Page
    {
        AircraftTableAdapter aircraftAdapter = new AircraftTableAdapter();
        public PlanesPage()
        {
            InitializeComponent();
            LoadAircraft();
        }

        private void LoadAircraft()
        {
            var aircraft = aircraftAdapter.GetData().Select(airplane => new AircraftControl(airplane)).ToList();
            AircraftList.ItemsSource = aircraft;
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedPath = openFileDialog.FileName;

                string saveDirectory = @"C:\Users\paulscriptum\source\repos\AviaPlace\images";

                string fileName = System.IO.Path.GetFileName(selectedPath);
                string destPath = System.IO.Path.Combine(saveDirectory, fileName);

                System.IO.File.Copy(selectedPath, destPath, true);

                ImgTbx.Text = destPath;

            }
        }

        private void AircraftList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AircraftList.SelectedItem is AircraftControl selectedAircraft)
            {
                ModelTbx.Text = selectedAircraft.model;
                CapacityTbx.Text = selectedAircraft.capacity.ToString();
                ImgTbx.Text = selectedAircraft.image;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                aircraftAdapter.InsertQuery(ModelTbx.Text, Convert.ToInt32(CapacityTbx.Text), ImgTbx.Text);
                App.WriteLog($"Добавлен новый самолет - {ModelTbx.Text}");
                Clear();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AircraftList.SelectedItem is AircraftControl selectedAircraft && ValidateFields())
            {
                aircraftAdapter.UpdateQuery(ModelTbx.Text, Convert.ToInt32(CapacityTbx.Text), ImgTbx.Text, selectedAircraft.id);
                App.WriteLog($"Изменен самолет с идентификатором {selectedAircraft.id}");
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AircraftList.SelectedItem is AircraftControl selectedAircraft)
            {
                aircraftAdapter.DeleteQuery(selectedAircraft.id);
                App.WriteLog($"Самолет {selectedAircraft.model} с идентификатором {selectedAircraft.id} был удален");
                Clear();
            }
            else MessageBox.Show("Выберите самолет для удаления");
        }

        public bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(ModelTbx.Text) || string.IsNullOrWhiteSpace(CapacityTbx.Text) ||
            string.IsNullOrWhiteSpace(ImgTbx.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return false;
            }

            int validation = 0;
            string nameP = @"^(?=.{2,75}$)[A-Za-zА-Яа-я0-9]+(-[A-Za-zА-Яа-я0-9]+)?\s+[A-Za-zА-Яа-я0-9\s]+$";
            if (Regex.IsMatch(ModelTbx.Text, nameP)) validation++;
            else MessageBox.Show("Неверный формат названия");
            string capacityP = @"^\d+(\.\d+)?$";
            if (Regex.IsMatch(CapacityTbx.Text, capacityP)) validation++;
            else MessageBox.Show("Неверный формат вместимости");

            return validation == 2;
        }

        private void Clear()
        {
            ModelTbx.Text = string.Empty;
            CapacityTbx.Text = string.Empty;
            ImgTbx.Text = string.Empty;
            LoadAircraft();
        }

        private void AircraftList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (AircraftList.SelectedItem is AircraftControl selectedAircraft)
            {
                MessageBox.Show(selectedAircraft.id.ToString());
            }
        }
    }
}
