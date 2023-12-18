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


            ////user makes a mage
            //if (userClass.Equals("Mage"))
            //{

            //    Console.WriteLine("Enter a name for your character:");
            //    string name = Console.ReadLine();
            //    Mage userCharacter = new Mage(name);
            //    Console.WriteLine("Hello " + name);

            //}



           










        }
    }
}