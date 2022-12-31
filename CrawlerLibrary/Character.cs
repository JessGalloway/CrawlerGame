using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class Character
    {
        //Fields
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _attack;
        private int _defense;
        private int _speed;
        private int _level;
        private int _experience;
        private int _gold;
        private int _maxGold;
        private int _maxExperience;
        private int _maxLevel;
        private int _maxAttack;
        private int _maxDefense;
        private int _maxSpeed;
        private int _accuracy;
        private int _maxAccuracy;
        private int _dodge;
        private int _maxDodge;

        //Properties
        public string Name { get { return _name; } set { _name = value; } }
        
        public int Health { get { return _health; } set { _health = value; } }

        public int MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }

        public int Attack { get { return _attack; } set { _attack = value; } }

        public int Defense { get { return _defense; } set { _defense = value; } }

        public int Speed { get { return _speed; } set { _speed = value; } }

        public int Level { get { return _level; } set { _level = value; } }

        public int Experience { get { return _experience; } set { _experience = value; } }

        public int Gold { get { return _gold; } set { _gold = value; } }

        public int MaxGold { get { return _maxGold; } set { _maxGold = value; } }

        public int MaxExperience { get { return _maxExperience; } set { _maxExperience = value; } }

        public int MaxLevel { get { return _maxLevel; } set { _maxLevel = value; } }

        public int MaxAttack { get { return _maxAttack; } set { _maxAttack = value; } }

        public int MaxDefense { get { return _maxDefense; } set { _maxDefense = value; } }

        public int MaxSpeed { get { return _maxSpeed; } set { _maxSpeed = value; } }

        public int Accuracy { get { return _accuracy; } set { _accuracy = value; } }

        public int MaxAccuracy { get { return _maxAccuracy; } set { _maxAccuracy = value; } }

        public int Dodge { get { return _dodge; } set { _dodge = value; } }

        public int MaxDodge { get { return _maxDodge; } set { _maxDodge = value; } }


        //Constructor

        public Character(string name, int health, int maxHealth, int attack, int maxAttack, int defense, int maxDefense, int speed, int maxSpeed, int level, int maxLevel, int experience, int maxExperience, int gold, int maxGold, int accuracy, int maxAccuracy, int dodge, int maxDodge) 
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

        public Character() { }

        //Methods

        public void DisplayStats()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health + "/" + MaxHealth);
            Console.WriteLine("Attack: " + Attack + "/" + MaxAttack);
            Console.WriteLine("Defense: " + Defense + "/" + MaxDefense);
            Console.WriteLine("Speed: " + Speed + "/" + MaxSpeed);
            Console.WriteLine("Level: " + Level + "/" + MaxLevel);
            Console.WriteLine("Experience: " + Experience + "/" + MaxExperience);
            Console.WriteLine("Gold: " + Gold + "/" + MaxGold);
            Console.WriteLine("Accuracy: " + Accuracy + "/" + MaxAccuracy);
            Console.WriteLine("Dodge: " + Dodge + "/" + MaxDodge);
        }

        public override string ToString()
        {
            return $"----------------------------------\n" +
                   $"{Name}   lvl:{Level} Gold: {Gold}\n" +
                   $"     Hp: {Health}/{MaxHealth}  \n" +
                   $" Exp: {Experience} {MaxExperience}\n" +
                   $"----------------------------------\n" +
                   $"       Atk: {Attack}\n" +
                   $"       Def: {Defense}\n" +
                   $"       Spd: {Speed}\n" +
                   $"----------------------------------\n";
        }

        public virtual int CalcDefense() { return Defense; }

        public virtual int CalcAccuracy() { return Accuracy; }

        public virtual int CalcDodge() { return Dodge; }

        public virtual int CalcAttack() { return Attack; }
        
        public abstract int CalcDamage();

        

        
        
        
    }//end class
}//end namespace
