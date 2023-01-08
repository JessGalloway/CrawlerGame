using CrawlerLibrary;
using System;
using System.Collections.Generic;
using System.Dynamic;
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

            int origRow = Console.CursorTop;
            int origCol = Console.CursorLeft;

            Console.Clear();
            Console.WriteLine("\n");
            CenterString("May I have your name Traveler?");
            Console.SetCursorPosition(origCol + 57, origRow - 17);
            string userName = Console.ReadLine().ToString();
            

            



            Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterString($"{userName} has now been registered. Please wait while we prepare the game.");
            Console.WriteLine("\n");
            Console.ResetColor();

            jumpPoint:
            weaponJump:

            Weapons w1 = new Weapons("unaarmed", 5, 8, 100, 14, WeaponType.None);
                
           
           //w Weapons w2 = new Weapons("Sword", 5, 8, 100, 14, WeaponType.Sword);
            //Weapons.GetWeaponType(w2);
            //Console.ReadKey();
            Player test = new Player(name: userName, 30, 30, 11, 12, 11, 11, 10, 0, 20, 0, 2000, 100, 40, w1);
           

            CenterString("Choose a Weapon? Press enter when done.");
          
            CenterString("[1] Dagger");
            Console.WriteLine();
            CenterString("[2] Sword");
            Console.WriteLine();
            CenterString("[3] Axe");
            Console.WriteLine();
            CenterString("[4] Bow");
            Console.WriteLine();
            CenterString("[5] Bo-Staff");
            Console.WriteLine();
            CenterString("[6] Katana");
            Console.WriteLine();
            CenterString("[7] Magic");
            Console.WriteLine();
            CenterString("[8] Whip");
            Console.WriteLine();
            CenterString("[9] Unarmed");
            //string weaponChoice = Console.ReadKey(true).Key.ToString();


            string Response = Console.ReadKey(true).Key.ToString();
            Response = Response[1].ToString();
            
            // string output = string.Format("You have chosen \t{0}", "userName");
            //Console.WriteLine("\t\tWelcome. Please type your name.");
            //Console.WriteLine("user picked " + Response);
            //D4 D7
            switch (Response) 
            {
                
                case "1" :
                    CenterString("I feel kinda bad, you wanna take a bow as well?");
                    Console.WriteLine();
                    Weapons dagger = new Weapons("Dagger", 7, 13, 100, 20, WeaponType.Dagger);
                    w1 = dagger;
                    break;
                case "2":
                    CenterString("Nothing flashy just the right tool for the job.");
                    Console.WriteLine();
                    Weapons sword = new Weapons("Sword", 5, 5, 100, 0, WeaponType.Sword);
                    w1 = sword;
                    break;
                case "3":
                    CenterString("I had an Axe once...");
                    Console.WriteLine();
                    Weapons axe = new Weapons("Axe", 1, 5, 100, 0, WeaponType.Axe);
                    w1 = axe;
                    break;
                case "4":
                    CenterString("Fear of close ecounters? Preference for anonymity? Guess it's none of my business....");
                    Console.WriteLine();
                    Weapons bow = new Weapons("Bow", 1, 5, 100, 0, WeaponType.Bow);
                    w1 = bow;
                    break;
                case "5":
                    CenterString("That's what I call class!");
                    Console.WriteLine();
                    Weapons boStaff = new Weapons("Bo-Staff", 1, 5, 100, 0, WeaponType.BoStaff);
                    w1 = boStaff;
                    break;
                case "6":
                    CenterString("A fitting weapon indeed...");
                    Console.WriteLine();
                    Weapons katana = new Weapons("Katana", 1, 5, 100, 0, WeaponType.Katana);
                    w1 = katana;
                    break;
                case "7":
                    CenterString("Not everyday you meet a magic user.");
                    Console.WriteLine();
                    Weapons magic = new Weapons("Magic", 1, 5, 100, 0, WeaponType.Magic);
                    w1 = magic;
                    break;
                case "8":
                    CenterString("Happy hunting cowboy.");
                    Console.WriteLine();
                    Weapons whip = new Weapons("Whip", 1, 5, 100, 0, WeaponType.Whip);
                    w1 = whip;
                    break;
                case "9":
                    Weapons unarmed = new Weapons("Unarmed", 1, 5, 100, 0, WeaponType.None);
                    CenterString("Unarmed it is +5 to");
                    
                    Console.WriteLine(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    CenterString("Just kiddin, have fun in there!");
                    w1 = unarmed;
                    break;
                default:
                    Weapons defaultChoice = new Weapons("Unarmed", 1, 3, 100, 0, WeaponType.None);
                    CenterString("Bold Choice, my friend.");
                    w1 = defaultChoice;

                    break;

            }

            //Console.WriteLine(w1);
            //Console.WriteLine();
            CenterString($"{w1}");
            Console.ReadKey();



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

            int score = 0;
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

                

                //int score = 0;

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
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            CenterString("You attacked swiftly!");
                            Console.WriteLine();
                            Console.ResetColor();
                            Battle.DoBattle(test, testMon);

                            if (testMon.Health <= 0)
                            {
                                
                                Console.WriteLine("\n");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                CenterString($"{testMon.Name} has been defeated!");
                                CenterString("-------------------------------");
                                
                                score++;
                                CenterString($"Score: {score}");
                                CenterString("-----------------------------");
                                
                                int goldgrab = testMon.Gold;
                                int expgrab = testMon.Experience;
                                test.Gold = goldgrab;
                                test.Experience = expgrab;

                                CenterString($"{test.Name} has gained {goldgrab} gold!");
                                Console.WriteLine();
                                CenterString($"{test.Name} has gained {expgrab} experience!");

                                test.Gold += goldgrab;
                                test.Experience += expgrab;

                                CenterString("Do you wish to change weapons? [Y] or [N]");
                                string newWeapon2 = Console.ReadKey(true).Key.ToString().ToLower();

                                switch (newWeapon2)
                                {
                                    case "y":
                                        goto weaponJump;
                                        break;
                                    case "n":
                                        CenterString("Onward.");
                                        break;
                                    default:
                                        CenterString("Onward.");
                                        break;
                                }

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
                                Console.WriteLine();
                                CenterString("You bulstered your defensed and survived the onslaught!");
                                continue;
                                
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
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            CenterString("Gotta love the adventurous types!");
                            Console.WriteLine();
                            Console.ResetColor();

                            score = 0;
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
                string overMenu = "+-+-+-+-+-+-+-";
                string underMenu = "-+-+-+-+-+-+-+";
                CenterString(overMenu);
                Console.WriteLine();
                CenterString("W. Play Game");
                Console.WriteLine();
                CenterString("S. How to Play");
                Console.WriteLine();
                CenterString("E. Exit");
                Console.WriteLine();
                CenterString(underMenu);

                Console.WriteLine("");
                string quote = "The first and greatest victory is to conquer oneself;";
                string quote1 = "to be conquered by oneself is of all things most shameful and vile.";
                
                string Plato = "~Plato";
             
                CenterString(quote);
                CenterString(quote1);
                Console.WriteLine();
                CenterString(Plato);

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
