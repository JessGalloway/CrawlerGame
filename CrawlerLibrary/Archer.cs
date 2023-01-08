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
        public Archer(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int speed, int level, int maxLevel, int experience, int gold, int accuracy, int dodge) : base (name, maxHealth, health, attack, maxAttack, defense, speed, level, experience, gold, accuracy,dodge)
        {


        }

        public Archer() 
        {
            Name = "Thief";
            Experience = 10;
            Attack = 05;
            MaxAttack = 7;
            Defense = 10;            
            Speed = 75;            
            Gold = 8;            
            Accuracy = 100;
            Dodge = 5;
            

        }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }


    }//end Archer
}//end namesace
