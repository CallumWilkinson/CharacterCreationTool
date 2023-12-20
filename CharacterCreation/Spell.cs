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

        int spellDamage {  get; set; }
        int manaCost { get; set; }
      
        //contructor
        public Spell(int spellDamage, int manaCost)
        {
            this.spellDamage = spellDamage;
            this.manaCost = manaCost;
        }


        //methods
    }
}
