using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public abstract class Spell
    {

        //fields 

        public int spellDamage;
        public int manaCost;
        public string name;

        //contructor
        public Spell(string name,int spellDamage, int manaCost)
        {
            this.name = name;
            this.spellDamage = spellDamage;
            this.manaCost = manaCost;
        }


        //methods
    }
}
