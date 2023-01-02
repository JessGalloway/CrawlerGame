using System;
using System.Collections.Generic;
using System.IO;
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

        public Monster(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) : base(name, health, maxHealth, attack, maxAttack, defense, maxDefense, speed, maxSpeed, level, maxLevel, experience, maxExperience, gold, maxGold, accuracy, maxAccuracy, dodge, maxDodge)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Attack = attack;
            MaxAttack = maxAttack;
            Defense = defense;
            MaxDefense = maxDefense;
            Speed = speed;
            MaxSpeed = maxSpeed;
            Level = level;
            MaxLevel = maxLevel;
            Experience = experience;
            MaxExperience = maxExperience;
            Gold = gold;
            MaxGold = maxGold;
            Accuracy = accuracy;
            MaxAccuracy = maxAccuracy;
            Dodge = dodge;
            MaxDodge = maxDodge;
            


        }

        //Methods


        public override string ToString()
        {
            return $"                                         ----------------------------------\n" +
                   $"                                              {Name}      lvl:{Level}      Gold: {Gold}\n" +
                   $"                                                       Hp: {Health}/{MaxHealth}  \n" +
                   $"                                                       Exp: {Experience}/{MaxExperience}\n" +
                   $"                                          ----------------------------------\n" +
                   $"                                                        Atk: {Attack}\n" +
                   $"                                                        Def: {Defense}\n" +
                   $"                                                        Spd: {Speed}\n" +
                   $"                                          ----------------------------------\n";
        }

        public override int CalcDamage()
        {
            return new Random().Next(Attack, MaxAttack + 1);
        }

        public int DropGold() 
        {
            if (Health <= 0) 
            {
                return Gold;
                
            }//end if
            else
            {
                return 0;

            }//end else
        
        }//end DropGold

        public int DropExp()
        {
            if (Health <= 0)
            {
                return Experience;

            }//end if
            else
            {
                return 0;

            }//end else

        }//end DropGold

        public static Monster GetMonster() 
        {

            Archer archer = new Archer("Archer", 20, 20, 10, 13, 10, 13, 10, 13, 10, 15, 10, 15, 15, 20, 65, 100, 15, 50);

            SwordsWoman swordsWoman = new SwordsWoman("SwordsWoman", 25, 15, 13, 16, 15, 20, 20, 26, 13, 15, 20, 25, 30, 36, 75, 100, 40, 50);

            SwordsMan swordsMan = new SwordsMan("SwordsMan", 25, 15, 13, 16, 15, 20, 20, 26, 13, 15, 20, 25, 30, 30, 76, 100, 40, 50);

            Mage mage = new Mage("Mage", 20, 10, 17, 25, 10, 10, 100, 100, 10, 10, 20, 25, 40, 50, 20, 100, 10, 50);



            var thief = new Archer();
            var undead = new SwordsWoman();
            var vagrant = new SwordsMan();
            var elf = new Mage();

            List<Monster> monsters = new List<Monster>() 
            {
                archer, swordsMan, swordsWoman, mage, archer, mage, swordsMan, swordsWoman,thief, undead, vagrant, elf, elf, vagrant, undead, thief 
            
            };

            int randDraw = new Random().Next(monsters.Count);
            Monster monster = monsters[randDraw];
            return monster;         
        
        }//end GetMonster



    }//end Monster
}//end namespace
