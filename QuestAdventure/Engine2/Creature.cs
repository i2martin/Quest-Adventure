using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Creature
    {
        public int currentHP { get; set; }
        public int MaxHP { get; set; }

        public Creature(int cHP, int mHP)
        {
            currentHP = cHP;
            MaxHP = mHP;
        }
    }
}
