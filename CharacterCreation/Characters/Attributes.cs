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
        public int BaseHealth { get; private set; }


        //constructor
        public Attributes(int level, int basehealth) 
        {
            Level = level;
            BaseHealth = basehealth;
        }



        
        

    }
}
