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
            var mage = new Mage("Nibzy");
            var warrior = new Warrior("Chadwar");
               

            //act
            mage.AttackCharacter(warrior);
            int warriorHealth = warrior.BaseHealth;

            //assert
            Assert.That(warriorHealth, Is.EqualTo(90));
        }


        [Test(Description = "Make a warrior called Vein")]
        public void testName()
        {
            var warrior = new Warrior("Vein");


            string warName = warrior.Name;

            Assert.That(warName, Is.EqualTo("Vein"));
        }

    }
    
}