using CrawlerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction/Title
            CenterString("Welcome, Friends");
            Console.Title = "My Game";
            #endregion
            bool playGame = false;
            
            MainMenu();
            do
            {

                bool reload = false;

                do
                {

                    Console.Clear();
                    bool quit = false;

                    string pInfo = " C) Player Info";
                    string mInfo = "  F) Monster Info\n";

                    Console.Write(pInfo);
                    alignStringRight(mInfo);
                    Console.WriteLine();
                    CenterString("   W) Attack");
                    CenterString("   S) Defend");
                    CenterString("  D) Dodge");
                    CenterString("R) Run");
                    CenterString(" X) Quit");

                    string battleChoice = Console.ReadKey(true).Key.ToString().ToLower();

                    switch (battleChoice)
                    {
                        case "c":
                            //TODO ADD player info
                            //Console.WriteLine("Player Info");
                            //Console.WriteLine("Name: " + player.Name);
                            //Console.WriteLine("Health: " + player.Health);
                            //Console.WriteLine("Attack: " + player.Attack);
                            //Console.WriteLine("Defense: " + player.Defense);
                            //Console.WriteLine("Speed: " + player.Speed);
                            //Console.WriteLine("Level: " + player.Level);
                            //Console.WriteLine("Experience: " + player.Experience);
                            //Console.WriteLine("Gold: " + player.Gold);
                            //Console.WriteLine("Accuracy: " + player.Accuracy);
                            //Console.WriteLine("Dodge: " + player.Dodge);
                            //Console.WriteLine("Press any key to continue.");
                            //Console.ReadKey(true);
                            reload = true;
                            break;
                        case "f":
                            //TODO ADD monster info
                            //Console.WriteLine("Monster Info");
                            //Console.WriteLine("Name: " + monster.Name);
                            //Console.WriteLine("Health: " + monster.Health);
                            //Console.WriteLine("Attack: " + monster.Attack);
                            //Console.WriteLine("Defense: " + monster.Defense);
                            //Console.WriteLine("Speed: " + monster.Speed);
                            //Console.WriteLine("Level: " + monster.Level);
                            //Console.WriteLine("Experience: " + monster.Experience);
                            //Console.WriteLine("Gold: " + monster.Gold);
                            //Console.WriteLine("Accuracy: " + monster.Accuracy);
                            //Console.WriteLine("Dodge: " + monster.Dodge);
                            //Console.WriteLine("Press any key to continue.");
                            //Console.ReadKey(true);
                            reload = true;
                            break;
                        case "w":
                            
                            Console.WriteLine("You attack the monster!");
                            //Console.ReadKey(true);
                           // reload = true;
                            break;
                        case "s":
                            //Console.Clear();
                            Console.WriteLine("You defend against the monster!");
                            //Console.WriteLine("Press any key to continue.");
                            //Console.ReadKey(true);
                           // reload = true;
                            break;
                        case "d":
                        case "a":
                            //Console.Clear();
                            Console.WriteLine("You dodge the monster's attack!");
                            //Console.WriteLine("Press any key to continue.");
                            //Console.ReadKey(true);
                            //reload = true;
                            break;
                        case "r":
                            //Console.Clear();
                            Console.WriteLine("You run away from the monster!");
                            //Console.WriteLine("Press any key to continue.");
                            //Console.ReadKey(true);
                            //reload = true;
                            break;
                        case "x":
                        case "escape":
                            Console.Clear();
                            Console.WriteLine("Are you sure you want to quit? (Y/N)");
                            string quitChoice = Console.ReadKey(true).Key.ToString().ToLower();
                            if (quitChoice == "y")
                            {
                                reload = false;
                                quit = true;
                            }
                            else if (quitChoice == "n")
                            {
                                Console.WriteLine("Back For more Adventure?!");
                                
                                quit = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            //Console.WriteLine("Press any key to continue.");
                            //Console.ReadKey(true);
                            //reload = true;
                            break;

                    }





                } while (!reload && !playGame);




            } while (playGame);
            #region Player Name
            //TODO request player name and store

            #endregion

            #region Environment
            //TODO create environment

            #endregion

            #region Menu

            #endregion




        }//end Main()

        public static void CenterString(string s)
        {
            int leftPadding = (Console.WindowWidth - s.Length) / 2;
            Console.Write(s.PadLeft(leftPadding + s.Length).PadRight(Console.WindowWidth));
        }

        public static void alignStringRight(string b) 
        {
            
            int leftPadding = (Console.WindowWidth) - b.Length  * 2;
            Console.Write(b.PadLeft(leftPadding + b.Length).PadRight(Console.WindowWidth)); ;

        }
        public static bool MainMenu() 
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                string overMenu = "-------------";
                CenterString(overMenu);
                CenterString("W. Play Game");
                CenterString("S. How to Play");
                CenterString("E. Exit");
                string menuChoice = Console.ReadKey(true).Key.ToString().ToLower();

                switch (menuChoice)
                {
                    case "w":
                        bool playGame = true;
                        return playGame;
                        return false;
                    case "s":
                        Console.WriteLine("How to Play");
                        break;
                    case "e":
                    case "Escape":
                        return false;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (true);
            
            

            

            

            
        }


    }//end class
}//end Namespace
