using CrawlerLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
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

            MainMenu();

            bool quit = false;
                        
            do
            {
                Console.Clear();
                Console.WriteLine("\n");
                CenterString("May I have your name Traveler?");
                string userName = Console.ReadLine().ToString();
                Console.WriteLine();
                Thread.Sleep(600);

                Console.Clear();
                Console.WriteLine();
                CenterString($"{userName} has now been registered. Please wait while we prepare the game.");                
                Player test = new Player(name: userName, 30, 30, 10, 13, 10, 13, 10, 13, 5, 30, 0, 45, 0, 999999, 100, 100, 50, 100);
                Console.WriteLine();
                Console.WriteLine($"{test}");

                CenterString("Generating player environment");
                Thread.Sleep(500);
                CenterString(".");
                Thread.Sleep(500);
                CenterString(".");
                Thread.Sleep(450);
                CenterString(".");
                Thread.Sleep(400);
                CenterString(".");
                Thread.Sleep(300);
                Console.WriteLine();

                CenterString("Initilized");

                Console.WriteLine("\n\n");
                


                string environment = GetEnvironment();
                string envForm = (String.Format("{0," + ((Console.WindowWidth /2) + (environment.Length / 2)) + "}", environment));
                Console.WriteLine(envForm);
                Console.WriteLine("\n\n");



                bool reload = false;

                do
                {

                    
                    

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

                            Console.WriteLine("\n\n");
                            Console.WriteLine(test);
                            Console.WriteLine();

                            CenterString("Continue? Y/N");
                            Console.WriteLine("\n\n");
                            string quitChoiceInfo1 = Console.ReadKey(true).Key.ToString().ToLower();
                            if (quitChoiceInfo1 == "y")
                            {
                                Console.WriteLine();
                                CenterString("On we go!");
                                Console.WriteLine();
                            }
                            else if (quitChoiceInfo1 == "n")
                            {
                                Console.WriteLine("\n\n");
                                CenterString("Come Back for more adventure!");
                                Console.WriteLine("\n\n\n\n\n");
                                quit = true;
                            }





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
                               
                                quit = false;
                            }
                            else if (quitChoice == "n")
                            {
                                Console.WriteLine("\n\n\n\n");
                                CenterString(" Come Back For more Adventure?!");
                                Console.WriteLine("\n\n\n\n");
                                
                                quit = true;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            //Console.WriteLine("Press any key to continue.");
                            //Console.ReadKey(true);
                            //reload = true;
                            
                            break;

                    }





                } while (!reload && !quit);




            } while (!quit);
       




        }//end Main()

        public static void CenterString(string s)
        {
            int leftPadding = (Console.WindowWidth - s.Length) / 2;
            Console.Write(s.PadLeft(leftPadding + s.Length).PadRight(Console.WindowWidth));
        }//end string center

        public static void alignStringRight(string b) 
        {
            
            int leftPadding = (Console.WindowWidth) - b.Length  * 2;
            Console.Write(b.PadLeft(leftPadding + b.Length).PadRight(Console.WindowWidth)); ;

        } //end string right
        public static bool MainMenu() 
        {
            do
            {
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine();
                string overMenu = "--------------";
                string underMenu = "--------------";
                CenterString(overMenu);
                Console.WriteLine();
                CenterString("W. Play Game");
                Console.WriteLine();
                CenterString("S. How to Play");
                Console.WriteLine();
                CenterString("E. Exit");
                Console.WriteLine();
                CenterString(underMenu);
               
                string menuChoice = Console.ReadKey(true).Key.ToString().ToLower();

                switch (menuChoice)
                {
                    case "w":
                        bool playGame = true;
                        return playGame;
                        //return false;
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
                       
        }//end main menu

        public static string GetEnvironment() 
        {
            string[][] environment = new string[3][];

            environment[0] = new string[3];

            environment[0][0] = "Forest";
            environment[0][1] = "Desert";
            environment[0][2] = "Mountain";

            environment[1] = new string[3];
            
            environment[1][0] = "Cave";
            environment[1][1] = "Swamp";
            environment[1][2] = "River";

            environment[2] = new string[3];

            environment[2][0] = "Town";
            environment[2][1] = "Castle";
            environment[2][2] = "Dungeon";

            Random rand = new Random();
            int index = rand.Next(environment.Length);
            string randomEnvironment = environment[index][index];

            return randomEnvironment;
        } //end get environment


    }//end class
}//end Namespace
