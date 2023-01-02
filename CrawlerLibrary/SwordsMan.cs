using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class SwordsMan : Monster
    {
        //Fields

        //properties

        //constructors
        public SwordsMan(string name, int health, int maxHealth, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base(name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge)
        {

            experience = 11;
            attack = 12;
            maxAttack = 15;
            defense = 13;
            maxDefense = 19;
            speed = 60;
            maxSpeed = 100;
            gold = 00;
            maxGold = 15;
            accuracy = 90;
            maxAccuracy = 100;
            dodge = 35;
            maxDodge = 50;


        }//end FQCTOR

        public SwordsMan() { }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
