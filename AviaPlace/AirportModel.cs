using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AviaPlace
{
    public class AirportModel
    {
        public string name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string code { get; set; }

        public static List<AirportModel> DeserializeFromCsv()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (dialog.ShowDialog() == true)
            {
                var csvData = File.ReadAllLines(dialog.FileName, Encoding.GetEncoding("windows-1251"));
                var headers = csvData[0].Split(',');

                return csvData.Skip(1)
                    .Select(row => row.Split(',')
                    .Select((value, index) => new { value, index })
                    .ToDictionary(x => headers[x.index].Trim().ToLower(), x => x.value))
                    .Select(dict => new AirportModel
                    {
                        name = dict.ContainsKey("name") ? dict["name"] : null,
                        country = dict.ContainsKey("country") ? dict["country"] : null,
                        city = dict.ContainsKey("city") ? dict["city"] : null,
                        code = dict.ContainsKey("code") ? dict["code"] : null
                    })
                    .ToList();
            }

            return null;
        }
    }
}
