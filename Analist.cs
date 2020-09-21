using System;
using System.Collections.Generic;

namespace Plutus
{
    class Analist
    {
        public string analise(string database)
        {
            string data = "";
            double total = 0;
            Dictionary<string, double> sums = new Dictionary<string, double>();

            foreach (string category in Enum.GetNames(typeof(Categories)))
            {
                sums.Add(category, 0);
            }

            string[] db = database.Split('$');

            for (int i = 0; i < db.Length - 4; i += 4)
            {
                string date = db[i].Replace(">", "");
                string name = db[i + 1];
                double price = Convert.ToDouble(db[i + 2]);
                string category = db[i + 3];

                sums[category] += price;
                total += price;
            }

            foreach (string category in Enum.GetNames(typeof(Categories)))
            {
                string percent = String.Format("{0:0.00}", sums[category] / total * 100);
                data += category + " " + sums[category] + " (" + percent + "%)" + System.Environment.NewLine;
            }

            return data != "" ? data : "No data found!";
        }
    }
}
