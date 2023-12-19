using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public class CombatSystem
    {
        

       public void Combat(Character player, Character enemy)
        {
            while (player.BaseHealth > 0 && enemy.BaseHealth > 0)
            {
                //player's turn
                player.AttackCharacter(enemy);

                //enemy's turn
                enemy.AttackCharacter(player);
               
            }
            if (player.BaseHealth > enemy.BaseHealth)
            {
                Console.WriteLine("you win");

            }
            else Console.WriteLine("you died");
        }

      
    }
}
