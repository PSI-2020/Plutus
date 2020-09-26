using System;
using System.Diagnostics;
using System.IO;

namespace Plutus
{
    class DataManager
    {
        readonly Analist analist = new Analist();
        public readonly string income = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/income.txt");
        public readonly string expenses = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "db/expenses.txt");

        public void WriteFile(string path, string data)
        {
            try
            {
                using var sw = new StreamWriter(path, true);
                sw.WriteLine(data);
                sw.Close();

            }
            catch (IOException) {}
        }
        public string[] ReadData(string path){
            try
            {
                using var sr = new StreamReader(path);
                var data = sr.ReadToEnd().Split('$');
                

                for (var i = 0; i < data.Length - 4; i += 4)
                {
                    var date = data[i].Replace(">", "");
                    var name = data[i + 1];
                    var price = data[i + 2];
                    var category = data[i + 3];
                }

                sr.Close();
                return data;
            }
            catch (IOException)
            {
                return new string[] {"No data found in database located at " + path};
            }
        }

        public string ReadFile(string path)
        {
            try
            {
                using var sr = new StreamReader(path);
                var data = sr.ReadToEnd();
                sr.Close();
                return data;
            }
            catch (IOException)
            {
                return "No data found in database located at " + path;
            }
        }

        public string GiveAnalisis(string path) => analist.Analise(ReadData(path));
    }
}
