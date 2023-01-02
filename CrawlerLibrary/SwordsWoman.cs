using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class SwordsWoman : Monster
    {

        //Fields

        //properties

        //constructors
        public SwordsWoman(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base(name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge)
        {

            


        }//end FQCTOR

        public SwordsWoman() 
        {
            Name = "Undead";
            Experience = 11;
            Attack = 12;
            MaxAttack = 15;
            Defense = 13;
            MaxDefense = 19;
            Speed = 60;
            MaxSpeed = 100;
            Gold = 00;
            MaxGold = 15;
            Accuracy = 90;
            MaxAccuracy = 100;
            Dodge = 35;
            MaxDodge = 50;

        }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }
    }//end class
}//end namespace
