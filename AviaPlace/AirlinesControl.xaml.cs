using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для AirlinesControl.xaml
    /// </summary>
    public partial class AirlinesControl : UserControl
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public string country {  get; set; }
        public string image {  get; set; }
        public AirlinesControl(AviaPlaceDataSet.AirlinesRow airline)
        {
            InitializeComponent();
            id = airline.id;
            name = airline.name;
            country = airline.country;
            image = airline.image;

            NameTbk.Text = name;
            CountryTbk.Text = country;
            Image.Source = new BitmapImage(new Uri(image));
        }
    }
}
