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

        //[Test(Description = "make a mage and give it a name")]
        //public void Test1()
        //{
        //    //arrange
        //    var mage = new Mage("Jack");

        //    //act
        //    string actual = mage.Name;

        //    //assert
        //    Assert.That(actual, Is.EqualTo("Jack"));  
            

        //}

        //[Test(Description = "Character A Attacks Character B")]

        //public void TestAttack()
        //{
        //    ////arrange
        //    //var CharacterA = new Character("Nibzy", 10, 2);
        //    //var CharacterB = new Character("Chadowform", 10, 1);

        //    ////act
        //    //CharacterA.AttackCharacter(CharacterB);
        //    //int CharBBaseHealth = CharacterB.BaseHealth;


        //    ////assert
        //    //Assert.That(CharBBaseHealth, Is.EqualTo(8));

        //}

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


    }
    
}