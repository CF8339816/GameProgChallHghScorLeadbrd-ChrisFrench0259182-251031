using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameProgChallHghScorLeadbrd_ChrisFrench0259182_251031
{
    internal class Program
    {
        static int Score;
        static Random random = new Random();
        static string[] initals = new string[3];



        //static char initial1;
        //static char initial2;
        //static char initial3;



        static void Main(string[] args)
        {

            GenerateScore();
            Thread.Sleep(1000);
            Initials();
            Thread.Sleep(3000);
            WriteScoreInitals();

        }
        //methods below
        //m1
        static void GenerateScore()
        {
            Score = random.Next(1, 1001);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($" score:");
            Console.WriteLine( Score);
            Console.ReadKey(true);


            Console.ForegroundColor = ConsoleColor.White;

        }

        //m2
        static void Initials()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your First inital");
            Console.ForegroundColor = ConsoleColor.Blue;
            initals[0] = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your Second inital");
            Console.ForegroundColor = ConsoleColor.Blue;
            initals[1] = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your Third inital");
            Console.ForegroundColor = ConsoleColor.Blue;
            initals[3] = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }


        //m3
        static void WriteScoreInitals()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("High Scores ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Score} ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"- ");
            Console.ForegroundColor = ConsoleColor.Blue;
           foreach (string inital in initals)
            {
                Console.WriteLine(inital);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        //m4



        //m5


    
    }
}
