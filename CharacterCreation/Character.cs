using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CharacterCreation
{
    public class Character
    {
        //fields
        public string Name { get; set; }

        public int BaseHealth { get; private set; }
        public int CurrentHealth { get; private set; }
        public int BaseMana { get; private set; }
        public int CurrentMana { get; private set; }
        public int MeleeDamage { get; private set; }
        public int Defense { get; private set; }

        //constructor
        public Character(string name, int baseHealth, int meleeDamage)
        {
            this.Name = name;
            this.BaseHealth = baseHealth;
            this.MeleeDamage = meleeDamage;
        }

        //methods
        public void TakeDamage(int damage)
        {
            BaseHealth = Math.Max(0, BaseHealth - damage); // Ensure health doesn't go below 0

        }

        public void AttackCharacter(Character target)
        {
            target.TakeDamage(MeleeDamage);
        }
       
    
    }
}
