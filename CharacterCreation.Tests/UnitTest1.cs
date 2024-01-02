using CharacterCreation;
using NuGet.Frameworks;
using NUnit.Framework;
using CharacterCreation.Characters;
using CharacterCreation.Spells;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

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
            var mage = new Mage("Nibzy", 100, 1);
            var warrior = new Warrior("Chadwar", 100, 1);
            var autoattack = new AutoAttack();


            //When
            mage.CastDamageSpell(autoattack, warrior);
            int warriorHealth = warrior.BaseHealth;

            //Then
            Assert.That(warriorHealth, Is.EqualTo(95));
        }


        [Test(Description = "Make a warrior called Vein")]
        public void testName()
        {
            var warrior = new Warrior("Vein", 100, 1);


            string warName = warrior.Name;


            Assert.That(warName, Is.EqualTo("Vein"));
        }





        [Test(Description = "mage attacks then heals")]

        public void combat2()
        {
            //Given
            var mage = new Mage("Player1", 100, 1);
            var warrior = new Warrior("NPC", 100, 1);
            var autoattack = new AutoAttack();
            var healingtouch = new Healing_Touch();


            //When
            mage.CastDamageSpell(autoattack, warrior);

            //then
            Assert.That(warrior.BaseHealth, Is.EqualTo(95));

            //when
            warrior.CastDamageSpell(autoattack, mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(95));

            //when
            mage.CastHealingSpell(healingtouch, mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(100));

            //when 
            warrior.CastDamageSpell(autoattack, mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(95));





        }


        [Test(Description = "Mage casts fireball on warrior")]

        public void castingfireball()
        {
            //given
            var mage = new Mage("Nibz", 100, 1);
            var warrior = new Warrior("James", 200, 1);
            var fireball = new Fireball();


            //when
            mage.CastDamageSpell(fireball, warrior);


            //then
            Assert.That(mage.BaseMana, Is.EqualTo(70));
            Assert.That(warrior.BaseHealth, Is.EqualTo(170));
        }

        [Test(Description = "Mage casts frostbolt on warrior")]

        public void castingfrostbolt()
        {
            //given
            var mage = new Mage("Nibz", 100, 1);
            var warrior = new Warrior("James", 200, 1);
            var frostbolt = new Frostbolt();


            //when
            mage.CastDamageSpell(frostbolt, warrior);


            //then
            Assert.That(mage.BaseMana, Is.EqualTo(50));
            Assert.That(warrior.BaseHealth, Is.EqualTo(180));
        }

        [Test(Description = "mage casts healing touch after taking damage from a warrior")]
        public void castinghealingtouch()
        {

            //given
            var mage = new Mage("Callum", 100, 1);
            var warrior = new Warrior("Jamus", 100, 1);
            var autoattack = new AutoAttack();
            var healingtouch = new Healing_Touch();

            //when
            warrior.CastDamageSpell(autoattack, mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(95));

            //when
            mage.CastHealingSpell(healingtouch, mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(100));



        }


        [Test(Description = "mage casts fireball, warrior casts frostbolt, mage heals, warrior auto attacks and mage casts frostbolt")]
        public void combat4()
        {
            //given
            var mage = new Mage("Callum", 100, 1);
            var warrior = new Warrior("Hellgoodwar", 100, 1);
            var autoattack = new AutoAttack();
            var fireball = new Fireball();
            var frostbolt = new Frostbolt();
            var healingtouch = new Healing_Touch();


            //when 
            mage.CastDamageSpell(fireball, warrior);

            //then
            Assert.That(warrior.BaseHealth, Is.EqualTo(70));

            //when
            warrior.CastDamageSpell(frostbolt, mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(80));

            //when
            mage.CastHealingSpell(healingtouch, mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(100));

            //when 
            warrior.CastDamageSpell(autoattack, mage);

            //then
            Assert.That(mage.BaseHealth, Is.EqualTo(95));

            //when
            mage.CastDamageSpell(frostbolt, warrior);

            //then
            Assert.That(warrior.BaseHealth, Is.EqualTo(50));



        }

        //[Test(Description = "make a character and set its level")]
        //public void setcharlevel() 
        //{
        //    //given
        //    var mage = new Mage("nibz", 100, 1);
           


        //    //when


        //    //then


        //}

    }
    
}