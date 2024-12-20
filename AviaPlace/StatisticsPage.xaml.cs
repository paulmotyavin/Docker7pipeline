using System.Linq;
using LiveCharts;
using LiveCharts.Wpf;
using AviaPlace.AviaPlaceDataSetTableAdapters;
using System.Windows.Controls;

namespace AviaPlace
{
    public partial class StatisticsPage : Page
    {
        private AirlineSalesTableAdapter airlineSales = new AirlineSalesTableAdapter();

        public StatisticsPage()
        {
            InitializeComponent();
            ShowAirlineSalesStats();
        }

        private void ShowAirlineSalesStats()
        {
            var airlineSalesData = airlineSales.GetData();

            AirlineSalesChart.Series.Clear();
            AirlineSalesChart.AxisX.Clear();
            AirlineSalesChart.AxisY.Clear();

            var salesSeries = new ColumnSeries
            {
                Title = "Продажи",
                Values = new ChartValues<decimal>(airlineSalesData.Select(x => x.TotalSales)),
                FontSize = 22,
                LabelPoint = point => point.Y.ToString("C", System.Globalization.CultureInfo.CurrentCulture)
            };

            AirlineSalesChart.AxisX.Add(new Axis
            {
                Title = "Авиакомпании",
                FontSize = 22,
                Labels = airlineSalesData.Select(x => x.AirlineName).ToArray()
            });

            AirlineSalesChart.AxisY.Add(new Axis
            {
                Title = "Сумма продаж",
                FontSize = 22,
                LabelFormatter = value => value.ToString("C", System.Globalization.CultureInfo.CurrentCulture) // Форматирование как валюта
            });

            AirlineSalesChart.Series.Add(salesSeries);

            var seatsSeries = new ColumnSeries
            {
                Title = "Проданные места",
                Values = new ChartValues<int>(airlineSalesData.Select(x => x.SoldSeats)),
                FontSize = 22,
                LabelPoint = point => point.Y.ToString()
            };

            AirlineSalesChart.Series.Add(seatsSeries);
        }
    }
}
