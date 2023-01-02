using System;
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
        public Mage(string name, int health, int maxHealth, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base(name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge)
        {

            experience = 23;
            attack = 19;
            maxAttack = 25;
            defense = 0;
            maxDefense = 0;
            speed = 65;
            maxSpeed = 100;
            gold = 20;
            maxGold = 25;
            accuracy = 45;
            maxAccuracy = 100;
            dodge = 40;
            maxDodge = 50;


        }//end FQCTOR

        public Mage() { }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
