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


        [Test(Description = "Mage attacks warrior")]
        public void TestAttack()
        {
            //Given
            var mage = new Mage("Nibzy", 100, 20);
            var warrior = new Warrior("Chadwar", 100, 10);


            //When
            mage.AttackCharacter(warrior);
            int warriorHealth = warrior.BaseHealth;

            //Then
            Assert.That(warriorHealth, Is.EqualTo(80));
        }


        [Test(Description = "Make a warrior called Vein")]
        public void testName()
        {
            var warrior = new Warrior("Vein", 100, 20);


            string warName = warrior.Name;


            Assert.That(warName, Is.EqualTo("Vein"));
        }





        [Test(Description ="mage attacks then heals")]

        public void combat2()
        {
            //Given
            var mage = new Mage("Player1", 80, 20);
            var warrior = new Warrior("NPC", 100, 30);
            

            //When
            mage.AttackCharacter(warrior);

            //then
            Assert.That(warrior.BaseHealth, Is.EqualTo(80));

            //when
            warrior.AttackCharacter(mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(50));

            //when
            mage.HealSelf();

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(60));

            //when 
            warrior.AttackCharacter(mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(30));


           
            

        }


        [Test(Description = "Mage casts fireball on warrior")]

        public void castingfireball()
        {
            //given
            var mage = new Mage("Nibz", 100, 20);
            var warrior = new Warrior("James", 200, 5);
            var fireball = new Fireball();


            //when
            mage.cast(fireball, warrior);


            //then
            Assert.That(mage.BaseMana, Is.EqualTo(90));
            Assert.That(warrior.BaseHealth, Is.EqualTo(170));
        }

        [Test(Description = "Mage casts frostbolt on warrior")]

        public void castingfrostbolt()
        {
            //given
            var mage = new Mage("Nibz", 100, 20);
            var warrior = new Warrior("James", 200, 5);
            var frostbolt = new Frostbolt();


            //when
            mage.cast(frostbolt, warrior);


            //then
            Assert.That(mage.BaseMana, Is.EqualTo(80));
            Assert.That(warrior.BaseHealth, Is.EqualTo(150));
        }

    }
    
}