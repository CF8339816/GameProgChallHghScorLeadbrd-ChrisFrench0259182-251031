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
        static string[ , , ] initials;





        static void Main(string[] args)
        {

            GenerateScore();
            Thread.Sleep(1000);
            Initials();


        }
        //methods below
        //m1
        static void GenerateScore()
        {
            Score = random.Next(1, 1001);
            Console.WriteLine($" score: {Score}");
            Console.ReadKey(true);




        }

        //m2
        static void Initials()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your 3 initials");
            Console.ForegroundColor = ConsoleColor.Blue;
            initials[0,1,2] = Console.ReadLine();
           
        }


        //m3


        //m4



        //m5


    
    }
}
