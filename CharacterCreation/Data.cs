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


            //intitialise values
            int rows = 0;
            int cols = 0;

            //first loop to determine size of the array
            using ( var reader = new StreamReader(csvPath))
            {


                //ignore headers
                reader.ReadLine();

                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    cols = Math.Max(cols, values.Length);
                    rows++;
                }


               
               
            }


            //initialise 2D array
            string[,] spellsArray = new string[rows, cols];


            //populate the array
            int currentRow = 0;
            using (var reader = new StreamReader(csvPath))
            {

                //ignore headers
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    for (int i = 0; i < values.Length; i++)
                    {
                        spellsArray[currentRow, i] = values[i];
                    }
                    currentRow++;
                }
            }

        }

    }
}
