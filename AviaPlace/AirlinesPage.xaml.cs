using AviaPlace.AviaPlaceDataSetTableAdapters;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для AirlinesPage.xaml
    /// </summary>
    public partial class AirlinesPage : Page
    {
        AirlinesTableAdapter airlinesAdapter = new AirlinesTableAdapter();
        public AirlinesPage()
        {
            InitializeComponent();
            LoadAirlines();
        }

        private void LoadAirlines()
        {
            var airlines = airlinesAdapter.GetData().Select(airline => new AirlinesControl(airline)).ToList();
            AirlinesList.ItemsSource = airlines;
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

                string saveDirectory = @"C:\Users\paulscriptum\source\repos\AviaPlace\images"; // Укажите свой путь

                string fileName = System.IO.Path.GetFileName(selectedPath);
                string destPath = System.IO.Path.Combine(saveDirectory, fileName);

                System.IO.File.Copy(selectedPath, destPath, true);

                ImgTbx.Text = destPath;

            }
        }

        private void AirlinesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AirlinesList.SelectedItem is AirlinesControl selectedAirline)
            {
                NameTbx.Text = selectedAirline.name;
                CountryTbx.Text = selectedAirline.country;
                ImgTbx.Text = selectedAirline.image;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                airlinesAdapter.InsertQuery(NameTbx.Text, CountryTbx.Text, ImgTbx.Text);
                App.WriteLog($"Добавлена новая авиакомпания - {NameTbx.Text}");
                Clear();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AirlinesList.SelectedItem is AirlinesControl selectedAirline && ValidateFields())
            {
                airlinesAdapter.UpdateQuery(NameTbx.Text, CountryTbx.Text, ImgTbx.Text, selectedAirline.id);
                App.WriteLog($"Изменена авиакомпания с идентификатором {selectedAirline.id}");
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AirlinesList.SelectedItem is AirlinesControl selectedAirline)
            {
                airlinesAdapter.DeleteQuery(selectedAirline.id);
                App.WriteLog($"Авиакомпания {selectedAirline.name} была удалена");
                Clear();
            }
            else MessageBox.Show("Выберите авиакомпанию для удаления");
        }

        public bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(NameTbx.Text) || string.IsNullOrWhiteSpace(CountryTbx.Text) ||
            string.IsNullOrWhiteSpace(ImgTbx.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return false;
            }

            int validation = 0;
            string nameP = @"^(?=.{2,50}$)(?:[A-Za-zА-Яа-я0-9]+(?:\s+[A-Za-zА-Яа-я0-9]+)*)$";
            if (Regex.IsMatch(NameTbx.Text, nameP)) validation++;
            else MessageBox.Show("Неверный формат названия");
            string countryP = @"^[А-Я][а-я]{2,45}$";
            if (Regex.IsMatch(CountryTbx.Text, countryP)) validation++;
            else MessageBox.Show("Неверный формат страны");

            return validation == 2;
        }

        private void Clear()
        {
            NameTbx.Text = string.Empty;
            CountryTbx.Text = string.Empty;
            ImgTbx.Text = string.Empty;
            LoadAirlines();
        }
    }
}
