using CharacterCreation.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CharacterCreation.Characters
{
    public abstract class Character
    {
        //FIELDS
        public string Name { get; set; }

        public int BaseHealth { get; private set; }

        public int BaseMana = 100;

        public int HealPower = 10;



        //CONSTRUCTOR
        public Character(string name, int baseHealth)
        {
            Name = name;
            BaseHealth = baseHealth;
            

        }

        //METHODS


        //character takes damage to reduce health by x ammount
        public void TakeDamage(int damage)
        {
            BaseHealth = Math.Max(0, BaseHealth - damage); // Ensure health doesn't go below 0

        }


        //character reduces its base mana by x ammount
        public void ReduceMana(int manaCost)
        {
            BaseMana = Math.Max(0, BaseMana - manaCost);
        }



        //character casts a damaging spell
        public void CastDamageSpell(DamageSpell spell, Character target)
        {
            target.TakeDamage(spell.spellDamage);
            ReduceMana(spell.manaCost);
        }


        //character heals itself, increaseing its health by x ammount
        public void HealSelf()
        {
            BaseHealth = Math.Max(0, BaseHealth + HealPower);
        }


    }
}
