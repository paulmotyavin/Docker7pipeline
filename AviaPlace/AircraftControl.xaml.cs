using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для AircraftControl.xaml
    /// </summary>
    public partial class AircraftControl : UserControl
    {
        public int id { get; set; }
        public string model { get; set; }
        public int capacity { get; set; }
        public string image { get; set; }
        public AircraftControl(AviaPlaceDataSet.AircraftRow aircraft)
        {
            InitializeComponent();
            id = aircraft.id;
            model = aircraft.model;
            capacity = aircraft.capacity;
            image = aircraft.image;

            ModelTbk.Text = model;
            CapacityTbk.Text = $"Вместимость: {capacity}";
            Image.Source = new BitmapImage(new Uri(image));
        }
    }
}
