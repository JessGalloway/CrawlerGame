using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class Player : Character
    {
        //Fields
        private bool _defend;
        //Properties

        public bool defend { get; set; }


        //public PlayerClass CharacterClass { get; set; }



        //Constructors

        public Player(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base (name, maxHealth, health, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge)
        {
            //CharacterClass = characterClass;
        }

        public Player() { }

        
        //public string GetPlayerClass(PlayerClass characterClass)
        // {


        // }


        //Mehods
        public override int CalcDamage()
        {
            return new Random().Next(Attack, MaxAttack + 1);

        }//end CalcDa

        


        /*public int ExperienceToLevel()
        {
            if (Experience >= MaxExperience) 
            {
                Level += 1;
                Experience = 0;
                MaxExperience += 10;
                MaxHealth += 10;
                MaxAttack += 5;
                MaxDefense += 5;
                MaxSpeed += 5;
                MaxAccuracy += 5;
                MaxDodge += 5;
                              
            }
            return Experience;
        }//end experice */


    }//end class
}//end namespace
