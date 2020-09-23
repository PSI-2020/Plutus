using System;
using System.Collections.Generic;

namespace Plutus
{
    class Analist
    {
        public string analise(string database)
        {
            var data = "";
            var total = 0.0;
            var sums = new Dictionary<string, double>();

            foreach (var category in Enum.GetNames(typeof(Categories)))
            {
                sums.Add(category, 0);
            }

            var db = database.Split('$');

            for (var i = 0; i < db.Length - 4; i += 4)
            {
                //var date = db[i].Replace(">", "");
                //var name = db[i + 1];
                var price = Convert.ToDouble(db[i + 2]);
                var category = db[i + 3];

                sums[category] += price;
                total += price;
            }

            foreach (var category in Enum.GetNames(typeof(Categories)))
            {
                var percent = total == 0
                    ? " (" + String.Format("{0:0.00}", 0) + "%)"
                    : " (" + String.Format("{0:0.00}", sums[category] / total * 100) + "%)";
                data += category + " " + sums[category] + percent + System.Environment.NewLine;
            }

            return data != "" ? data : "No data found!";
        }
    }
}
