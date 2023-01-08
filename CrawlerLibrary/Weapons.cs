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



        //public WeaponType weapon()
        //{
        //    Type = WeaponType.Sword;
        //    Type = WeaponType.Dagger;
        //    Type = WeaponType.Axe;
        //    Type = WeaponType.Bow;
        //    Type = WeaponType.BoStaff;
        //    Type = WeaponType.Katana;
        //    Type = WeaponType.Magic;
        //    Type = WeaponType.Whip;
        //    Type = WeaponType.None;
            
        //}



        //public list status conditons 

        //enums can implemented with interfaces

        //status manager 

        //like ipayable interfsce and payment mager class

        //Methods

        public override string ToString()
        {
            return $"{Name}\t{MinDamage} to {MaxDamage} Damage\n" +
                $"B: {Accuracy}%\n" +
                $"Bonus Dodge: {Dodge}%\n";
        }

       
        //public Weapons GetWeaponType(WeaponType s)
        //{
            
        //    Weapons dagger = new Weapons("Dagger", 1, 4, 0, 0, WeaponType.Dagger);
        //    Weapons sword = new Weapons("Sword", 1, 6, 0, 0, WeaponType.Sword);
        //    Weapons axe = new Weapons("Axe", 1, 8, 0, 0, WeaponType.Axe);
        //    Weapons bow = new Weapons("Bow", 7, 13, 100, 0, WeaponType.Bow);
        //    Weapons boStaff = new Weapons("Bo Staff", 1, 4, 0, 0, WeaponType.BoStaff);
        //    Weapons katana = new Weapons("Katana", 12, 16, 100, 30, WeaponType.Katana);
        //    Weapons Magic = new Weapons("Magic", 15, 20, 40, 30, WeaponType.Magic);
        //    Weapons Whip = new Weapons("Whip", 1, 4, 0, 0, WeaponType.Whip);
        //    Weapons none = new Weapons("Unarmed", 1, 2, 100, 0, WeaponType.None);
        //    switch (Type)
        //    {
        //        case WeaponType.Dagger:
        //            return dagger;
        //        case WeaponType.Sword:
        //            return sword;
        //        case WeaponType.Axe:
        //            return axe;
        //        case WeaponType.Bow:
        //            return bow;
        //        case WeaponType.BoStaff:
        //            return boStaff;
        //        case WeaponType.Katana:
        //            return katana;
        //        case WeaponType.Magic:
        //            return Magic;
        //        case WeaponType.Whip:
        //            return Whip;
        //        default:
        //            return none;
        //    }

        //}

    }//end class
}//end namespace
