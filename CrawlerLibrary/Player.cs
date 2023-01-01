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

        //Properties

        //public PlayerClass CharacterClass { get; set; }



        //Constructors

        public Player(string name, int health, int maxHealth, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base (name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge)
        {
            //CharacterClass = characterClass;
        }

        //public string GetPlayerClass(PlayerClass characterClass)
        // {


        // }


        //Mehods
        public override int CalcDamage()
        {
            //TODO Recaculate this 
            Random rand = new Random();
            int attckPower = rand.Next(Attack,MaxAttack );
            int defensePower = rand.Next(Defense,MaxDefense);
            int damage;
            int minDamage = Attack - 2;

            if (attckPower < defensePower)
            {
                return minDamage;

            }
            else if (attckPower > defensePower)
            {

                damage = (attckPower - defensePower) + attckPower;
                return damage;

            }
            else if (attckPower == defensePower)
            {
                Console.WriteLine("merely a flesh wound...");
                return minDamage - 2;

            }
            else 
            {
                Console.WriteLine("well that didnt work");
                return 0;
            
            }
            
        }

        

    }//end class
}//end namespace
