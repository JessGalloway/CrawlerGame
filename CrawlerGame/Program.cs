using CrawlerLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

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

           
            
            Console.Clear();
            Console.WriteLine("\n");
            CenterString("May I have your name Traveler?");
            string userName = Console.ReadLine().ToString();
            Console.WriteLine();
            Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterString($"{userName} has now been registered. Please wait while we prepare the game.");
            Console.ResetColor();

            jumpPoint:
            
            Player test = new Player(name: userName, 20, 20, 10, 13, 10, 13, 10, 13, 5, 30, 0, 45, 0, 999, 65, 100, 5, 50);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{test}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterString("Generating player environment");
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Green;
            CenterString("Initilized");
            Console.ResetColor();


            bool quit = false;
                        
            do
            {
   
                Console.WriteLine("\n\n");


                Monster testMon = Monster.GetMonster();
                string environment = GetEnvironment();
                string envForm = (String.Format("{0," + ((Console.WindowWidth /2) + (environment.Length / 2)) + "}", environment));
                Console.WriteLine();
                CenterString("You enter an area resembling a");
                Console.WriteLine();
                Console.WriteLine(envForm);
                Console.WriteLine();
                CenterString("Upon entering you encounter what seems to be a Lone ");
                Console.WriteLine();
                CenterString(testMon.Name);
                Console.WriteLine();
                CenterString("Certainly doesn't seem like the friendly type....");
                Console.WriteLine("\n\n");

                

                int score = 0;

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
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("\n\n");
                            Console.WriteLine(test);
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.ResetColor();

                            break;

                        case "f":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\n");
                            Console.WriteLine(testMon);
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.ResetColor();

                            break;

                        case "w":
                            Console.WriteLine();
                            CenterString("You attacked swiftly!");
                            Console.WriteLine();
                            Battle.DoBattle(test, testMon);

                            if (testMon.Health <= 0)
                            {
                                Console.WriteLine("\n");
                                CenterString($"{testMon.Name} has been defeated!");
                                Console.WriteLine("\n");
                                score++;

                                int goldgrab = testMon.Gold;
                                int expgrab = testMon.Experience;
                                test.Gold = goldgrab;
                                test.Experience = expgrab;

                                CenterString($"{test.Name} has gained {goldgrab} gold!");
                                Console.WriteLine();
                                CenterString($"{test.Name} has gained {expgrab} experience!");

                                test.Gold += goldgrab;
                                test.Experience += expgrab;



                                Console.ReadKey(true);
                                reload = true;
                            }


                            break;
                        case "s":

                            CenterString("You attempt to defend yourself!");
                            Battle.DoDefendBattle(testMon,test);

                            if (test.Health <= 0)
                            {
                                Console.WriteLine("\n");
                                CenterString("Even with defenses bulstered you couldn't withstand the onslaught..");
                                Console.WriteLine("\n");
                                CenterString($"{testMon}: GameOver-----GameOver-----GameOver----");
                                Console.WriteLine();
                                CenterString($"Score: {score}");

                            }
                            else
                            {
                                break;

                            }



                            break;
                        case "d":
                        case "a":
                            //Console.Clear();
                            CenterString("You attmpt to  dodge an attack!");
                            
                            Battle.DoDefendBattle(testMon, test);

                            if (test.Health <= 0)
                            {
                                Console.WriteLine("\n");
                                CenterString("Even with your speed and cunning you couldnt out maneuver your foe..");
                                Console.WriteLine("\n");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                CenterString($"{testMon}: GameOver-----GameOver-----GameOver----");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                CenterString($"Score: {score}");
                                Console.ResetColor();

                            }
                            else
                            {
                                break;

                            }
                            break;
                        case "r":
                            //Console.Clear();
                            CenterString("You attempt to run away from the fight!");

                            CenterString($"{testMon.Name} unleashes one last blow as you turn to run.");
                            Battle.DoRunBattle(testMon, test);
                            Console.WriteLine();

                            reload = true;
                            break;
                        case "x":
                        case "escape":
                            Console.Clear();
                            Console.WriteLine("Are you sure you want to quit? (Y/N)");
                            string quitChoice = Console.ReadKey(true).Key.ToString().ToLower();
                            if (quitChoice == "y")
                            {

                                quit = true;
                            }
                            else if (quitChoice == "n")
                            {
                                Console.WriteLine("\n\n\n\n");
                                CenterString(" Come Back For more Adventure?!");
                                Console.WriteLine("\n\n\n\n");
                                
                                quit = false;
                                
                                goto jumpPoint;
                            }
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                           CenterString("Invalid Choice");
                            Console.ResetColor();
                            //Console.WriteLine("Press any key to continue.");
                            //Console.ReadKey(true);
                            //reload = true;

                            break;

                    }//end switch

                    if (test.Health <= 0) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        CenterString("You've Died......");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\n\n\n\n");
                        
                        CenterString("No Mortal Escapes Death....");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        CenterString("===========");
                        CenterString("Final Score");
                        CenterString(Convert.ToString(score));
                        CenterString("===========");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(test);
                        Console.ReadKey(true);
                        Console.ResetColor();

                        Console.Clear();
                        CenterString("Do you wish to continue? Y/N");
                        string quitChoiceInfo = Console.ReadKey(true).Key.ToString().ToLower();
                        if (quitChoiceInfo == "y")
                        {
                            Console.WriteLine();
                            CenterString("Gotta love the adventurous types!");
                            Console.WriteLine();
                            
                            goto jumpPoint;
                        }
                        else if (quitChoiceInfo == "n")
                        {
                            Console.WriteLine("\n\n");
                            CenterString("Come Back for more adventure!");
                            Console.WriteLine("\n\n\n\n\n");
                            
                        }
                        quit = true;
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
