using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AviaPlace
{
    public class UserModel
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public static List<UserModel> DeserializeFromCsv()
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
                    .Select(dict => new UserModel
                    {
                        surname = dict.ContainsKey("surname") ? dict["surname"] : null,
                        name = dict.ContainsKey("name") ? dict["name"] : null,
                        email = dict.ContainsKey("email") ? dict["email"] : null,
                        password = dict.ContainsKey("password") ? dict["password"] : null,
                        role = dict.ContainsKey("role") ? dict["role"] : null
                    })
                    .ToList();
            }

            return null;
        }
    }
}
