using CharacterCreation;
using NuGet.Frameworks;
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


        //[Test(Description = "Mage attacks warrior")]
        //public void TestAttack2()
        //{
        //    //Given
        //    var mage = new Mage("Nibzy");
        //    var warrior = new Warrior("Chadwar");
               

        //    //When
        //    mage.AttackCharacter(warrior);
        //    int warriorHealth = warrior.BaseHealth;

        //    //Then
        //    Assert.That(warriorHealth, Is.EqualTo(90));
        //}


        //[Test(Description = "Make a warrior called Vein")]
        //public void testName()
        //{
        //    var warrior = new Warrior("Vein");


        //    string warName = warrior.Name;


        //    Assert.That(warName, Is.EqualTo("Vein"));
        //}


        [Test(Description = "mage and warrior fight, mage dies")]

        public void combat() 
        {
            //Given
            var mage = new Mage("Player1", 80, 20);
            var warrior = new Warrior("NPC", 100, 30);
            var combat = new CombatSystem();


            //When
            combat.Combat(mage,warrior);


            //Then
            Assert.That(mage.BaseHealth, Is.EqualTo(0));


        }
    }
    
}