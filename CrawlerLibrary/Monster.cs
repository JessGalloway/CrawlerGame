using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class Monster : Character
    {
        //Fields
        

        //Properties

        //Constructors
        public Monster() { }

        public Monster(string name, int health, int maxHealth, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base(name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge)
        {

        }

        //Methods


        public override string ToString()
        {
            return base.ToString();
        }

        public override int CalcDamage()
        {
            throw new NotImplementedException();
        }


    }//end Monster
}//end namespace
