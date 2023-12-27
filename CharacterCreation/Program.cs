using System.ComponentModel.Design;

namespace CharacterCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] validClasses = { "Mage", "Warlock", "Warrior", "Paladin" };

            Console.WriteLine("choose a class from below:");
            Console.WriteLine("Mage\nWarlock\nWarrior\nPaladin");
            string tempUserClass = Console.ReadLine();

            //convert first letter of string to capital letter and leave rest lower case
            char firstLetter = char.ToUpper(tempUserClass[0]);
            string restOfString = tempUserClass.Substring(1).ToLower();
            string userClass = firstLetter + restOfString;

            if (Array.IndexOf(validClasses, userClass) == -1)
            {
                Console.WriteLine("Error: That class doesn't exist, try choosing from the list above");
            }

            Mage player = null;

            //user makes a mage
            if (userClass.Equals("Mage"))
            {

                Console.WriteLine("Enter a name for your character:");
                string name = Console.ReadLine();
                player = new Mage(name, 80, 20);
                Console.WriteLine("Hello " + name);

            }

            //combat starts

            //make a warrior
            Warrior enemy1 = new Warrior("Warrior NPC", 100, 30);
            Console.WriteLine("You encountered a warrior called " + enemy1.Name);
            Console.WriteLine("Player health: " + player.BaseHealth +
                "\nPlayer attack: " + player.MeleeDamage);
            Console.WriteLine("Enemy Health: " + enemy1.BaseHealth +
                "\nEnemy attack " + enemy1.MeleeDamage);
            Console.WriteLine("Press 1 to attack " + enemy1.Name);

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    //combat loop

                    var combat = new CombatSystem();
                    combat.Combat(player, enemy1);
                    break;

                default:
                    Console.WriteLine("must enter 1 to attack");
                    break;


                

            }














        }
    }
}