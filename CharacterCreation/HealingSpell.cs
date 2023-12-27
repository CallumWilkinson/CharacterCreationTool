using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public class HealingSpell : Spell
    {

        //fields
        public int healPower;

        //constructor
        public HealingSpell(string name, int manaCost, int healPower)
           : base(name, manaCost)
        {
            this.healPower = healPower;
        }


        //methods
    }
}
