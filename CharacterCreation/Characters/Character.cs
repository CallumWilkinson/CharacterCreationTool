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

        public int BaseHealth;

        public int BaseMana = 100;

        public int HealPower = 10;

        public Attributes CharacterAttributes { get; private set; }

       

        




        //CONSTRUCTOR
        public Character(string name, int level)
        {
            Name = name;
            CharacterAttributes = new Attributes(level);
            BaseHealth = CharacterAttributes.BaseHealth;

        }

        //METHODS


        //character takes damage to reduce health by x ammount
        public void TakeDamage(int damage)
        {
            BaseHealth = Math.Max(0, BaseHealth - damage); // Ensure health doesn't go below 0
            

        }


        //character takes healing to increase health by x ammount
        public void TakeHealing(int healpower)
        {
            BaseHealth = Math.Min(100, BaseHealth + healpower);
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

        //character casts a healing spell
        public void CastHealingSpell(HealingSpell spell, Character target)
        {
            target.TakeHealing(spell.healPower);
            ReduceMana(spell.manaCost);
        }




    }
}
