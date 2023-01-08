using System;
using System.Collections;
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
        public Mage(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int speed, int level, int maxLevel, int experience, int gold, int accuracy, int dodge) : base(name, maxHealth, health, attack, maxAttack, defense, speed, level, experience, gold, accuracy, dodge)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Attack = attack;
            MaxAttack = maxAttack;
            Defense = defense;
            Speed = speed;
            Level = level;
            MaxLevel = maxLevel;
            Experience = experience;
            Gold = gold;
            Accuracy = accuracy;
            Dodge = dodge;

        }

        public Mage() 
        {
            Name = "Elf";
            Experience = 23;
            Attack = 19;
            MaxAttack = 25;
            Defense = 0;
            Speed = 65;
            Gold = 20;
            Accuracy = 100;
            Dodge = 0;

        }

        //methods

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
