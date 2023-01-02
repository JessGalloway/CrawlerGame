using System;
using System.Collections;
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
        public Archer(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base(name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge) 
        {

           
            
            
        }//end FQCTOR

        public Archer() 
        {
            Name = "Thief";
            Experience = 10;
            Attack = 05;
            MaxAttack = 7;
            Defense = 10;
            MaxDefense = 15;
            Speed = 75;
            MaxSpeed = 100;
            Gold = 8;
            MaxGold = 15;
            Accuracy = 75;
            MaxAccuracy = 100;
            Dodge = 25;
            MaxDodge = 50;

        }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }


    }//end Archer
}//end namesace
