using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public abstract class Character
    {
        //singletons , delegates and events look into these
        //Fields
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _attack;
        private int _maxAttack;
        private int _defense;
        private int _speed;
        private int _level;
        private int _maxLevel;
        private int _experience;
        private int _gold;
        private int _accuracy;
        private int _dodge;
        

        //Properties
        public string Name { get { return _name; } set { _name = value; } } 

        public int MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }

        public int Health { get { return _health; } set { _health = value > 0 ? value : 0; } }

        public int Attack { get { return _attack; } set { _attack = value; } }

        public int MaxAttack { get { return _maxAttack; } set { _maxAttack = value; } }

        public int Defense { get { return _defense; } set { _defense = value; } }

        public int Speed { get { return _speed; } set { _speed = value; } }

        public int Level { get { return _level; } set { _level = value; } }

        public int Experience { get { return _experience; } set { _experience = value; } }

        

        public int Gold { get { return _gold; } set { _gold = value; } }

        public int MaxLevel { get { return _maxLevel; } set { _maxLevel = value; } }

        public int Accuracy { get { return _accuracy; } set { _accuracy = value; } }

        public int Dodge { get { return _dodge; } set { _dodge = value; } }


       


        //Constructor

        public Character(string name, int maxHealth, int health, int attack, int maxAttack, int defense, int speed, int level, int experience, int gold, int accuracy, int dodge) 
        {

            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Attack = attack;
            MaxAttack = maxAttack;
            Defense = defense;
            Speed = speed;
            Level = level;
            Experience = experience;
            Gold = gold;
            Accuracy = accuracy;
            Dodge = dodge;
            
            
        }

        public Character() { }

        //Methods


        public override string ToString()
        {
            return $"                                         ----------------------------------\n" +
                   $"                                              {Name}      lvl:{Level}      Gold: {Gold}\n" +
                   $"                                                       Hp: {Health}/{MaxHealth}  \n" +
                   $"                                                       Exp: {Experience}\n" +
                   $"                                          ----------------------------------\n" +
                   $"                                                        Atk: {Attack}\n" +
                   $"                                                        Def: {Defense}\n" +
                   $"                                                        Spd: {Speed}\n" +
                   $"                                          ----------------------------------\n";
        }




      
        public virtual int CalcDefense() { return Defense; }

        public virtual int CalcAccuracy() { return Accuracy; }

        public virtual int CalcDodge() { return Dodge; }

        public virtual int CalcAttack() { return Attack; }
        
        public abstract int CalcDamage();

        
        
    }//end class
}//end namespace
