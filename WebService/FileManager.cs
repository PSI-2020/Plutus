using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Plutus
{


    public class FileManager
    {
        private static readonly string _directoryPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private readonly string _income = _directoryPath + "/WebService/Storage/income.xml";
        private readonly string _expenses = _directoryPath + "/WebService/Storage/expenses.xml";
        private readonly string _monthlyIncome = _directoryPath + "/WebService/Storage/monthlyIncome.xml";
        private readonly string _monthlyExpenses = _directoryPath + "/WebService/Storage/monthylExpenses.xml";
        private readonly string _goals = _directoryPath + "/WebService/Storage/goals.xml";
        private readonly string _budgets = _directoryPath + "/WebService/Storage/budgets.xml";
        private readonly string _carts = _directoryPath + "/WebService/Storage/carts.xml";
        public readonly string fontPathMaconodo = _directoryPath + "/True GUI/GUI resources/Macondo.ttf";
        public readonly string fontPathLilita = _directoryPath + "/True GUI/GUI resources/LilitaOne.ttf";

        public string GetFilePath(string type)
        {
            return type.ToLower() switch
            {
                "income" => _income,
                "expense" => _expenses,
                "monthlyincome" => _monthlyIncome,
                "monthlyexpenses" => _monthlyExpenses,
                _ => null,
            };
        }

        public async void EditPayment(Payment payment, Payment newPayment, string type)
        {
            var serializer = new XmlSerializer(typeof(List<Payment>));
            var list = await HttpService.GetPaymentsAsync(type);
            list[list.IndexOf(payment)] = newPayment;
            type = GetFilePath(type);

            File.WriteAllText(type, "");
            using (var stream = File.OpenWrite(type))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void UpdateGoals(List<Goal> list)
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            File.WriteAllText(_goals, "");
            using (var stream = File.OpenWrite(_goals))
            {
                serializer.Serialize(stream, list);
            }
        }

        public void SaveCarts(XElement carts) => carts.Save(_carts);

        public XElement LoadCarts()
        {
            if (!File.Exists(_carts)) return null;
            try
            {
                var carts = XElement.Load(_carts);
                return carts;
            }
            catch
            {
                return new XElement("Corrupted", "true");
            }
        }
    }
}
