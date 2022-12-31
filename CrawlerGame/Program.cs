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

            #region Player Name

            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();




            #endregion




        }//end Main()
        
        public static void CenterString(string s)
        {
            int leftPadding = (Console.WindowWidth - s.Length) / 2;
            Console.WriteLine(s.PadLeft(leftPadding + s.Length).PadRight(Console.WindowWidth));
        }



    }//end class
}//end Namespace
