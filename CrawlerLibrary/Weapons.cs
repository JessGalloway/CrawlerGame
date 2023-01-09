using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class Weapons
    {
        //Fields
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _accuracy;
        private int _dodge;
        private WeaponType _type;

        //Properties

        public string Name { get { return _name; } set { _name = value; } }

       

        public int Accuracy { get { return _accuracy; } set { _accuracy = value; } }

        public int Dodge { get { return _dodge; } set { _dodge = value; } }

        public WeaponType Type { get { return _type; } set { _type = value; } }
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }

        }


        //Constructors
        public Weapons(string name, int minDamage, int maxDamage, int accuracy, int dodge, WeaponType type)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            
            Accuracy = accuracy;
            Dodge = dodge;
            Type = type;



        }



        public static Weapons GetDropWeapon() 
        {

            Weapons sword = new Weapons("Sword of Norm", 10, 20, 100, 10, WeaponType.Sword);
            Weapons axe = new Weapons("Ishmal Axe", 15, 25, 100, 10, WeaponType.Axe);
            Weapons bow = new Weapons("Geit Bow", 10, 20, 100, 10, WeaponType.Bow);
            Weapons bowstaff = new Weapons("Hatzu broken staff", 10, 20, 100, 10, WeaponType.BoStaff);
            Weapons katan = new Weapons("Katzu", 25, 25, 100, 25, WeaponType.Katana);
            Weapons whip = new Weapons("The wild wild Whip", 12, 16, 75, 75, WeaponType.Whip);
            Weapons knucks = new Weapons("Sonic Knucks", 10, 14, 100, 40, WeaponType.None);


            

            List<Weapons> dropWeapons = new List<Weapons>() { sword, axe, bow, bowstaff, katan, whip, knucks };

            int randWeap = new Random().Next(dropWeapons.Count);
            Weapons dropWeapon = dropWeapons[randWeap];
            return dropWeapon;



        }


        //public list status conditons 

        //enums can implemented with interfaces

        //status manager 

        //like ipayable interfsce and payment mager class

        //Methods

        public override string ToString()
        {
            return $"\t\t\t\t\t\t~{Name}\t{MinDamage} to {MaxDamage} Damage~\n" +
                $"\t\t\t\t\t\t------------------------\n" +
                $"\t\t\t\t\t\t     Accuracy: {Accuracy}%\n" +
                $"\t\t\t\t\t\t    Bonus Dodge: {Dodge}%\n";
        }

       
       

    }//end class
}//end namespace
