using System.Windows.Controls;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для SeatClassControl.xaml
    /// </summary>
    public partial class SeatClassControl : UserControl
    {
        public int id { get; set; }
        public string Flight { get; set; }
        public int Rows { get; set; }
        public int Places { get; set; }
        public int Price { get; set; }
        public string Class { get; set; }
        public SeatClassControl(AviaPlaceDataSet.SeatsAndClassesRow sac, string Flight, string Class)
        {
            InitializeComponent();
            id = sac.id;
            Rows = sac.rows;
            Places = sac.places;
            Price = (int)sac.price;
            this.Flight = Flight;
            this.Class = Class;

            FlightTbk.Text = "Рейс: " + Flight;
            RowsTbk.Text = "Рядов: " + Rows;
            PlacesTbk.Text = "Мест: " + Places;
            ClassTbk.Text = "Класс: " + Class;
            PriceTbk.Text = "Стоимость: " + Price + " ₽";
        }
    }
}
