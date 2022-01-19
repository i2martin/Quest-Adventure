using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Player: Creature
    {
        public int Gold { get; set; }
        public int XP { get; set; }
        public int level { get; set; }

        public Player(int gold, int xp, int Level, int cHP, int mHP):base(cHP, mHP)
        {
            Gold = gold;
            XP = xp;
            level = Level;
        }

    }
}
