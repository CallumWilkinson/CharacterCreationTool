using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation.Characters
{
    public class Attributes
    {
        //fields
        public int Level;
        public int BaseHealth;
        public int BaseMana;
        


      


        //constructor
        public Attributes(int level) 
        {
            Level = level;
            BaseHealth = 90 + (Level * 10);
            BaseMana = 90 + (Level * 10);
        }



        
        

    }
}
