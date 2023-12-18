using CharacterCreation;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace CharacterCreation.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test(Description = "Mage attacks warrior")]
        public void TestAttack2()
        {
            //arrange
            var mage = new Mage("Nibzy", 8, 2);
            var warrior = new Warrior("Chadwar", 10, 4);
               

            //act
            mage.AttackCharacter(warrior);
            int warriorHealth = warrior.BaseHealth;

            //assert
            Assert.That(warriorHealth, Is.EqualTo(8));
        }


        [Test(Description = "Make a warrior called Vein")]
        public void testName()
        {
            var warrior = new Warrior("Vein", 100, 50);


            string warName = warrior.Name;

            Assert.That(warName, Is.EqualTo("Vein"));
        }

    }
    
}