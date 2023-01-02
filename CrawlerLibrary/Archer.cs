using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
      
    public class Archer : Monster
    {

        //Fields

        //properties

        //constructors
        public Archer(string name, int health, int maxHealth, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base(name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge) 
        {

            experience = 10;
            attack = 05;
            maxAttack = 7;
            defense = 10;
            maxDefense = 15;
            speed = 75;
            maxSpeed = 100;
            gold = 8;
            maxGold = 15;
            accuracy = 75;
            maxAccuracy = 100;
            dodge = 25;
            maxDodge = 50;
            
            
        }//end FQCTOR

        public Archer() { }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }


    }//end Archer
}//end namesace
