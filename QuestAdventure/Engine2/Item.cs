using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Item
    {
        public string name { get; set; }
        public int ID { get; set; }

        public Item(string Name, int id)
        {
            name = Name;
            ID = id;
        }
    }
}
