using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrawlerLibrary
{
    public class Battle
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            #region figure out


            //steps attacker attacks, does defender dodge, if no calc damage roll vs defense roll
            // if yes calc dodge roll against accuracy roll if hits calc damage roll vs defense roll 
            // dodge can be chosen instead of attack to calc that on next defending phase as well as block  = block increases defense roll + 1 to 5; 
            //accuracy check
            #endregion

            var roll = new Random().Next(1,101);
            Thread.Sleep(200);


            bool success = roll <= attacker.CalcAccuracy() - defender.CalcDodge();
            if (success)
            {
                int damage = attacker.CalcDamage();
                defender.Health -= damage;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage} damage!");
                Console.ResetColor();
            }
            else
            {
                
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{attacker.Name} missed {defender.Name}!");
                Console.ResetColor();
            }


        }//end DoAttack


        

        public static void DoBattle(Player player, Monster monster) 
        {

            DoAttack(player, monster);
            if (monster.Health > 0)
            {
                DoAttack(monster,player);
                
            }

        } //end DoBattle

        public static void DoDefendBattle( Monster monster, Player player) 
        {
            player.Defense += 5;
            
            DoAttack(monster, player);
          

        }//end DoDefendBattle

        public static void DoRunBattle(Monster monster, Character player) 
        {
            if (monster.Health > 0 && player.Health > 0) 
            {
                DoAttack(monster, player);


            }//end if 


        }//end DoRunBattle


    }//end class
}//end namespace
