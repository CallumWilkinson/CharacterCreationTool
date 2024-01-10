using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    internal class Data
    {
        public void LoadData() 
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Spells.xlsx");    
            using (var reader = new StreamReader(filePath))

                //file

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    // Add your test logic here
                }
        }

    }
}
