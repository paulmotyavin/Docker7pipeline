using AviaPlace.AviaPlaceDataSetTableAdapters;
using System.Data;
using System.Linq;
using System.Windows.Controls;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для LoggingPage.xaml
    /// </summary>
    public partial class LoggingPage : Page
    {
        LoggingTableAdapter loggingAdapter = new LoggingTableAdapter();
        public LoggingPage()
        {
            InitializeComponent();
            LoadLogging();
        }

        private void LoadLogging()
        {
            var logs = loggingAdapter.GetData()
                .Select(log => new
                {
                    log.id,
                    log.date,
                    log.action,
                    FullDisplay = $"[{log.date:dd.MM.yyyy HH:mm}]: {log.action}"
                })
                .OrderByDescending(log => log.date)
                .ToList();

            LoggingList.DisplayMemberPath = "FullDisplay";
            LoggingList.ItemsSource = logs;
        }
    }
}
