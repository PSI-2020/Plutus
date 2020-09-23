using System.IO;

namespace Plutus
{
    class DataManager
    {
        readonly string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Database.txt");
        readonly Analist analist = new Analist();

        public void Write(string data)
        {
            try
            {
                using var sw = new StreamWriter(path, true);
                sw.WriteLine(data);
                sw.Close();

            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.WriteLine("Something went wrong :s");
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
        public string GiveData()
        {
            var data = "";
            try
            {
                using var sr = new StreamReader(path);
                data = sr.ReadToEnd();
                sr.Close();
            }
            catch (IOException)
            {
                data = "No data found in database located at " + path;
            }
            return data;
        }
        public string GiveAnalisis()
        {
            var database = "none";
            try
            {
                using var sr = new StreamReader(path);
                // Read the stream as a string, and write the string to the console.
                database = sr.ReadToEnd();
                sr.Close();
            }
            catch (IOException)
            {
                return "none";
            }
            var data = analist.analise(database);
            return data;
        }
    }
}
