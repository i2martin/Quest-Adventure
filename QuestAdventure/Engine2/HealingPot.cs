using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class HealingPot: Item
    {
        public int Heal { get; set; }

        public HealingPot(int id, string Name, int heal) : base(Name,id)
        {
            Heal = heal;
        }
    }
}
