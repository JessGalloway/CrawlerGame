using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class Mage : Monster
    {
        //Fields

        //properties

        //constructors
        public Mage(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base(name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge)
        {

           


        }//end FQCTOR

        public Mage() 
        {
            Name = "Elf";
            Experience = 23;
            Attack = 19;
            MaxAttack = 25;
            Defense = 0;
            MaxDefense = 0;
            Speed = 65;
            MaxSpeed = 100;
            Gold = 20;
            MaxGold = 25;
            Accuracy = 45;
            MaxAccuracy = 100;
            Dodge = 40;
            MaxDodge = 50;

        }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
