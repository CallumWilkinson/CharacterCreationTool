using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public class Mage : Character
    {
        //fields



        //constructor with parameters
        public Mage(string name, int mageHealth, int mageDamage)
            : base(name, mageHealth, mageDamage)
        {

        }



        //methods
        public void cast(Spell spell, Character target)
        {
            target.TakeDamage(spell.spellDamage) ;
            this.ReduceMana(spell.manaCost);
        }
    }
}
