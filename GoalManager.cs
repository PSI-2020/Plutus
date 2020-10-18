using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Timers;
using System.Xml;
using System.Xml.Serialization;

namespace Plutus
{
    public class GoalManager 
    {
        private static readonly string GoalsFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Goals/");
        public readonly string Goals = GoalsFolder + "goals.xml";


        public List<Goal> ReadGoals()
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            List<Goal> list = null;

            try
            {
                if (!File.Exists(Goals)) return null;
                using Stream stream = File.OpenRead(Goals);
                list = serializer.Deserialize(stream) as List<Goal>;
            }
            catch
            {
                list = new List<Goal>();
            }
            return list;

        }

        public void AddGoal(Goal newGoal)
        {
            var serializer = new XmlSerializer(typeof(List<Goal>));
            List<Goal> list = null;

            try
            {
                using Stream stream = File.OpenRead(Goals);
                list = serializer.Deserialize(stream) as List<Goal>;
            }
            catch
            {
                list = new List<Goal>();
            }

            list.Add(newGoal);

            using (Stream stream = File.OpenWrite(Goals))
            {
                serializer.Serialize(stream, list);
            }
        }


    }
}
