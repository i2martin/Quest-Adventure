using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Location
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Item KeyRequired { get; set; }
        public Monster MonstersHere { get; set; }
        public Quest QuestAvailable { get; set; }
        public Location(int id, string Name, Item keyRequired, Monster monstersHere, Quest questAvailable)
        {
            ID = id;
            name = Name;
            KeyRequired = keyRequired;
            MonstersHere = monstersHere;
            QuestAvailable = questAvailable;
        }

    }
}
