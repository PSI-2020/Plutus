using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace SmartSaver
{
    class DataManager
    {
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Database.txt");
        string[] lines = { "First line", "Second line", "Third line" };
        Analist an = new Analist();

        public DataManager()
        {
            System.Diagnostics.Debug.WriteLine(path);
           
        }

        public void write(string data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(data);
                    sw.Close();
                }

            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.WriteLine("Something went wrong :s");
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
        public string giveData()
        {
            string data = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    // Read the stream as a string, and write the string to the console.
                    data = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.WriteLine("No data");
                System.Diagnostics.Debug.WriteLine(e);
                data = "No data found in database located at " + path;
            }
            return data;
        }
        public string giveAnalisis()
        {
            string database = "none";
            string data = "none";
            bool dataGot = true;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    // Read the stream as a string, and write the string to the console.
                    database = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.WriteLine("No data");
                System.Diagnostics.Debug.WriteLine(e);
                dataGot = false;
            }
            if (!dataGot) return "none";
            else
            {
                data = an.analise(database);
                return data;
            }
        }
    }
}
