using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;

namespace SmartSaver
{
    class Analist
    {
        string[] categories = {
            "Food",
            "Clothes",
            "Bills",
            "Other"};

        int[] collected =
        {
            0, 0, 0, 0};
        public Analist()
        {
           // string catNames = Form1.giveCategories();
        }

        public string analise(string database)
        {
            string data = "none";
            for(int i = 0; i < 4; i++)
            {
                collected[i] = 0;
            }
            int sum = 0;
            parseData(database);
            foreach(int i in collected)
            {
                sum = sum + i;
            }
            double a = (double)collected[0] / (double)sum;
            double b = (double)collected[1] / (double)sum;
            double c = (double)collected[2] / (double)sum;
            double d = (double)collected[3] / (double)sum;
            a = a * 100;
            b = b * 100;
            c = c * 100;
            d = d * 100;

            data = "Food - " + collected[0] + " (" + a.ToString("f1") + "%)" + "@Clothes - " + collected[1] + " (" + b.ToString("f1") + "%)" + "@Bills - " + collected[2] + " (" + c.ToString("f1") + "%)" + "@Other - " + collected[3] + " (" + d.ToString("f1") + "%)";
            data = data.Replace("@", System.Environment.NewLine);


            return data;
        }
        private void parseData(string database)
        {
            int len = database.Length;
            int dolCount = 0; ;
            string priceWord = "";
            int price = 0;
            string category = "";
            int nextDol = 0;
            for (int i = 0; i < len; i++)
            {
                if(database[i] == '>')
                {
                    dolCount = 0;
                    category = "";
                    priceWord = "";
                    price = 0;
                }
                if (database[i] == '$')
                {
                    i++;
                    dolCount++;
                } 
                if (dolCount == 2 && priceWord == "")
                {
                    nextDol = 0;
                    for(int y = 0; nextDol == 0; y++)
                    {
                        if(database[i + y] == '$')
                        {
                            priceWord = database.Substring(i, y);
                            System.Diagnostics.Debug.Write("price - ");
                            System.Diagnostics.Debug.WriteLine(priceWord);
                            nextDol = 1;
                        }
                    }
                }
                if (dolCount == 3 && category == "")
                {
                    nextDol = 0;
                    for (int y = 0; nextDol == 0; y++)
                    {
                        if (database[i + y] == '$')
                        {
                            category = database.Substring(i, y);
                            System.Diagnostics.Debug.Write("category - ");
                            System.Diagnostics.Debug.WriteLine(category);
                            nextDol = 1;
                        }
                    }
                }
                if (dolCount == 4 && price == 0)
                {
                    price = Int32.Parse(priceWord);
                    switch (category)
                    {
                        case "Food":
                            collected[0] = collected[0] + price;
                            break;
                        case "Clothes":
                            collected[1] = collected[1] + price;
                            break;
                        case "Bills":
                            collected[2] = collected[2] + price;
                            break;
                        case "Other":
                            collected[3] = collected[3] + price;
                            break;
                        default:
                            System.Diagnostics.Debug.Write("unknown category");
                            break;
                    }
                }

            }
        }
    }
}
