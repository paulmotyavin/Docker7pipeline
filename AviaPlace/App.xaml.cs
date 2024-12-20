using AviaPlace.AviaPlaceDataSetTableAdapters;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        static LoggingTableAdapter loggingAdapter = new LoggingTableAdapter();
        // Метод для хэширования данных
        public static string sha256(string randomString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        public static void WriteLog(string action)
        {
            loggingAdapter.InsertQuery(action, DateTime.Now);
        }
    }
}
