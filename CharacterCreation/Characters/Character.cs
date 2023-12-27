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

        public int MeleeDamage { get; private set; }


        public int HealPower = 10;



        //CONSTRUCTOR
        public Character(string name, int baseHealth, int meleeDamage)
        {
            Name = name;
            BaseHealth = baseHealth;
            MeleeDamage = meleeDamage;

        }

        //METHODS



        //character attacks another character, calling the take damage function on its target
        public void AttackCharacter(Character target)
        {
            target.TakeDamage(MeleeDamage);
        }


        //character takes damage to reduce health by x ammount
        public void TakeDamage(int damage)
        {
            BaseHealth = Math.Max(0, BaseHealth - damage); // Ensure health doesn't go below 0

        }

        //character heals itself, increaseing its health by x ammount
        public void HealSelf()
        {
            BaseHealth = Math.Max(0, BaseHealth + HealPower);
        }

        //character reduces its base manage by x ammount
        public void ReduceMana(int manaCost)
        {
            BaseMana = Math.Max(0, BaseMana - manaCost);
        }


    }
}
