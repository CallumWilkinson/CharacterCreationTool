using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation.Spells
{
    public abstract class Spell
    {

        //fields 

        public int manaCost;
        public string name;

        //contructor
        public Spell(string name, int manaCost)
        {
            this.name = name;
            this.manaCost = manaCost;

        }


        //methods
    }
}
