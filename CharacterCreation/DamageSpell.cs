using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public class DamageSpell : Spell
    {

        //fields
        public int spellDamage;

        //constructor
        public DamageSpell(string name, int manaCost, int spellDamage)
           : base(name, manaCost)
        {
            this.spellDamage = spellDamage;
        }


        //methods
    }
}
