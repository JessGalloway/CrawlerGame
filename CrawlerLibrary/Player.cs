using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class Player : Character
    {
        //Fields

        private int _maxExperience;

        private int _maxGold;




        //Properties

        public bool defend { get; set; }

        public Weapons EquippedWeapon { get; set; }

        private int MaxEperience { get { return _maxExperience; } set { _maxExperience = value; } }

        private int MaxGold { get { return _maxGold; } set { _maxGold = value; } }

        //private EquippedWeapon 

        //Constructors

        public Player(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int speed, int level, int experience, int maxExperience, int gold, int maxGold, int accuracy, int dodge, Weapons equippedWeapon) : base(name, maxHealth, health, attack, maxAttack, defense, speed, level, experience, gold, accuracy, dodge)
        {
            MaxEperience = maxExperience;
            MaxGold = maxGold;
            EquippedWeapon = equippedWeapon;
        }

        public Player() { }

     


        //Methods
        public override int CalcDamage()
        {

            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            return damage;

        }


       



        public override string ToString()
        {
            return $"                                         ----------------------------------\n" +
                   $"                                              {Name}      lvl:{Level}      Gold: {Gold}\n" +
                   $"                                                       Hp: {Health}/{MaxHealth}  \n" +
                   $"                                                       Exp: {Experience}/{MaxEperience}\n" +
                   $"                                          ----------------------------------\n" +
                   $"                                                        Atk: {Attack}\n" +
                   $"                                                        Def: {Defense}\n" +
                   $"                                                        Spd: {Speed}\n" +
                   $"                                          ----------------------------------\n";
        }

       

        
                
        
        
        
        

    }//end class
}//end namespace
