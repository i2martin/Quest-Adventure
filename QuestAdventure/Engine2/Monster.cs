using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Monster: Creature
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int Damage { get; set; }
        public int RewardGold { get; set; }
        public int RewardXP { get; set; }
        
        public Monster(int id, string Name, int damage, int rGold, int rXP, int cHP, int mHP): base(cHP, mHP)
        {
            ID = id;
            name = Name;
            Damage = damage;
            RewardGold = rGold;
            RewardXP = rXP;
        }

    }
}
