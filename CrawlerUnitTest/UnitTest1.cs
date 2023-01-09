using CrawlerLibrary;
using NuGet.Frameworks;
using System.Xml.Linq;

namespace CrawlerUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestElfValues()
        {



            //Arrange
            //instantiate a new Mage object
            Mage elf = new Mage("Elf", 15, 12, 12, 15, 13, 60, 10, 10, 10, 10, 100, 50);

            //variable to hold expected values

            string expectedName = "Elf";

            //Act
            // Execution of the code to be tested






            Assert.Equal(expectedName, elf.Name);

            //Assert.Equal(12, elf.Attack);
            //Assert.Equal(15, elf.MaxAttack);



        }

        [Fact]

        public void testAttackValues() 
        {
            Weapons none = new Weapons("Unarmed", 10, 10, 100, 10, WeaponType.None);
            Player test = new Player("Name", 30, 30, 11, 12, 11, 11, 10, 0, 20, 0, 2000, 100, 40, none);



            int attack = 11;

            int maxAttack = 12;


            Assert.Equal(attack, test.Attack);

            Assert.True(attack < maxAttack);


        }

        [Fact]

        public void TestCalcDamageMon() 
        {

            Weapons none = new Weapons("Unarmed", 10, 10, 100, 10, WeaponType.None);
            Player test = new Player("Name", 10, 30, 11, 12, 11, 11, 10, 0, 20, 0, 2000, 100, 40, none);

            Monster testMon = new SwordsMan("SwordsWoman", 25, 15, 13, 13, 15, 20, 20, 26, 13, 15, 100, 25);


            int expectedDamage = 13;

             //Battle.DoRunBattle(testMon,test);

            int damage = testMon.CalcDamage();

            Assert.True(expectedDamage == damage);
            


            
        }

        [Fact]

        public void TestPlayerCalcDamage() 
        {
            Weapons none = new Weapons("Unarmed", 10, 10, 100, 10, WeaponType.None);
            Player test = new Player("Name", 10, 30, 11, 12, 11, 11, 10, 0, 20, 0, 2000, 100, 40, none);

            int expectedDamage = 11;

           int damage = test.CalcDamage();


            Assert.True(expectedDamage == damage);

        }

        public void TestWeaponValue() 
        {

            Weapons katan = new Weapons("Katzu", 25, 25, 100, 25, WeaponType.Katana);

            int expectDamage = 25;

            int damage = katan.MaxDamage;

            Assert.True(expectDamage == damage);


        }

        public void TestArcherValue() 
        
        {
            Archer archer = new Archer("Archer", 20, 20, 10, 13, 10, 13, 10, 13, 10, 15, 100, 15);

            int expectedHealth = 28;

            int health = archer.Health;


            Assert.True(health != expectedHealth);

        }




       
    }
}