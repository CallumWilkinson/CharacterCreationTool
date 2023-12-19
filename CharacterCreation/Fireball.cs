using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public class Fireball : Spell
    {

        //fields
        string name = "Fireball";
        string description = "Hurl a ball of fire at the enemy dealing 10 damage";
        int manaCost = 10;
        int spellDamage = 30;


        //constructor


        //methods

        public void cast(Character caster, Character target)
        {
            target.TakeDamage(spellDamage);
            caster.reduceMana(manaCost);
        }




    }
}
