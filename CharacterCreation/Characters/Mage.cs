using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreation.Spells;

namespace CharacterCreation.Characters
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
        public void cast(DamageSpell spell, Character target)
        {
            target.TakeDamage(spell.spellDamage);
            ReduceMana(spell.manaCost);
        }
    }
}
