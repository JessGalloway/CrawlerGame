using System;
using System.Collections;
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
        public SwordsMan(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int speed, int level, int maxLevel, int experience, int gold, int accuracy, int dodge) : base(name, maxHealth, health, attack, maxAttack, defense, speed, level, experience, gold, accuracy, dodge)
        {


        }

        public SwordsMan() 
        {
            Name = "Sword Wielding Vagrant";
            Experience = 11;
            Attack = 12;
            MaxAttack = 15;
            Defense = 13;
            Speed = 60;
            Gold = 00;
            Accuracy = 100;
            Dodge = 3;

        }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }

    }//end class
}//end namespace
