using AviaPlace.AviaPlaceDataSetTableAdapters;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для AirportsPage.xaml
    /// </summary>
    public partial class AirportsPage : Page
    {
        AirportsTableAdapter airportsAdapter = new AirportsTableAdapter();
        public AirportsPage()
        {
            InitializeComponent();
            LoadAirports();
        }

        private void LoadAirports()
        {
            var airports = airportsAdapter.GetData().Select(airport => new
            {
                Id = airport.id,
                FullDisplay = $"{airport.name} ({airport.code}) - {airport.city}"
            }).ToList();
            AirportsList.ItemsSource = airports;
            AirportsList.DisplayMemberPath = "FullDisplay";
            AirportsList.SelectedValuePath = "Id";
        }

        private void AirportsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AirportsList.SelectedItem != null)
            {
                var airport = airportsAdapter.GetData().FirstOrDefault(x => x.id == Convert.ToInt32(AirportsList.SelectedValue));
                NameTbx.Text = airport.name;
                CityTbx.Text = airport.city;
                CountryTbx.Text = airport.country;
                CodeTbx.Text = airport.code;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                airportsAdapter.InsertQuery(NameTbx.Text, CityTbx.Text, CountryTbx.Text, CodeTbx.Text);
                App.WriteLog($"Добавлен новый аэропорт - {NameTbx.Text}");
                Clear();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AirportsList.SelectedItem != null && ValidateFields())
            {
                int selectedId = Convert.ToInt32(AirportsList.SelectedValue);
                airportsAdapter.UpdateQuery(NameTbx.Text, CityTbx.Text, CountryTbx.Text, CodeTbx.Text, selectedId);
                App.WriteLog($"Изменен аэропорт с идентификатором {selectedId}");
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AirportsList.SelectedItem != null)
            {
                int selectedId = Convert.ToInt32(AirportsList.SelectedValue);
                airportsAdapter.DeleteQuery(selectedId);
                App.WriteLog($"Удален аэропорт с идентификатором {selectedId}");
                Clear();
            }
            else MessageBox.Show("Выберите аэропорт для удаления");
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(NameTbx.Text) || string.IsNullOrWhiteSpace(CityTbx.Text) ||
                    string.IsNullOrWhiteSpace(CountryTbx.Text) || string.IsNullOrWhiteSpace(CodeTbx.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return false;
            }
            int validation = 0;
            string nameP = @"^[А-Я][а-я]{2,65}$";
            if (Regex.IsMatch(NameTbx.Text, nameP)) validation++;
            else MessageBox.Show("Неверный формат названия");
            string cityP = @"^[А-Я][а-я]{2,50}$";
            if (Regex.IsMatch(CityTbx.Text, cityP)) validation++;
            else MessageBox.Show("Неверный формат города");
            string countryP = @"^[А-Я][а-я]{2,45}$";
            if (Regex.IsMatch(CountryTbx.Text, countryP)) validation++;
            else MessageBox.Show("Неверный формат страны");
            string codeP = @"^[A-Z]{3}$";
            if (Regex.IsMatch(CodeTbx.Text, codeP)) validation++;
            else MessageBox.Show("Неверный формат кода аэропорта");

            return validation == 4;
        }

        private void Clear()
        {
            NameTbx.Text = string.Empty;
            CityTbx.Text = string.Empty;
            CountryTbx.Text = string.Empty;
            CodeTbx.Text = string.Empty;
            LoadAirports();
        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            List<AirportModel> forImport = AirportModel.DeserializeFromCsv();
            if (forImport != null)
            {
                foreach (AirportModel model in forImport)
                {
                    airportsAdapter.InsertQuery(model.name, model.city, model.country, model.code);
                }
                App.WriteLog($"Импортированы аэропорты!");
                LoadAirports();
            }
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            var airports = airportsAdapter.GetData();

            if (airports.Rows.Count > 0)
            {
                var saveFileDialog = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv" };

                if (saveFileDialog.ShowDialog() == true)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName, false, new System.Text.UTF8Encoding(true)))
                    {
                        writer.WriteLine(string.Join(",", airports.Columns.Cast<DataColumn>().Select(col => col.ColumnName)));

                        foreach (DataRow row in airports.Rows)
                        {
                            writer.WriteLine(string.Join(",", row.ItemArray));
                        }
                    }
                    App.WriteLog($"Экспортированы аэропорты!");
                    MessageBox.Show("Данные успешно экспортированы!");
                }
            }
            else MessageBox.Show("Нет данных для экспорта!");
        }
    }
}
