using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public class Data
    {
        public void LoadData() 
        {
            var csvPath = @"C:\Users\cmw65\Documents\myCode\CharacterCreation\Spells.csv";
            using( var reader = new StreamReader(csvPath))
            {
                while(reader.EndOfStream == false)
                {
                    var content = reader.ReadLine();
                }
            }
        }

    }
}
