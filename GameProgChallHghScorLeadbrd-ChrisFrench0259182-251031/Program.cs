using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameProgChallHghScorLeadbrd_ChrisFrench0259182_251031
{
    internal class Program
    {
        static int newScore;
        static Random random = new Random();
        // static string initals;
        //static string plrInitls;
        static string plrInitls = ($"{initial1}.{initial2}.{initial3}.");
        static string scoreData = ($"{hScore}, {plrInitls}");
        static string initial1;
        static string initial2;
        static string initial3;
        //static char initial1;
        //static char initial2;
        //static char initial3;
        //static char input;
        static string input;
        static List<string> ScoreInfo = new List<string>();
        static string filePath = "Scores.txt";
        static string hScore = newScore.ToString();
        static List<string> list;
        static void Main(string[] args)
        {

           // do
            //{

                genScore();
                Thread.Sleep(1000);
                Initials();
                Thread.Sleep(1000);
                WriteScoreInitals();
                Thread.Sleep(500);
                scoreList();
                Thread.Sleep(1000);
                //wtFile();
                //Thread.Sleep(1000);
                rfFile();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Do you want to exit? Type y for yes then press enter, press any other key to continue.");

                //char input = (char)Console.Read();
                input = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(input);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
            //}
            // while (char.ToLower(input) != 'y');
          //  while (input.ToLower() != "y");

         //   Console.ForegroundColor = ConsoleColor.White;
          //  Console.WriteLine("Exiting program...");






        }
        //methods below

        //m7



        //m8

        static void genScore()
        {
            newScore = random.Next(1, 1001);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($" score:");
            Console.WriteLine(newScore);
           // Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.White;
        }


        //m2
        static void Initials()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your First inital and press enter");
            Console.ForegroundColor = ConsoleColor.Blue;
            initial1 = Console.ReadLine();
            //initial1 = (char)Console.Read();
            //Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your Second inital and press enter");
            Console.ForegroundColor = ConsoleColor.Blue;
            initial2 = Console.ReadLine();
            //initial2 = (char)Console.Read();
            // Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your Third inital and press enter");
            Console.ForegroundColor = ConsoleColor.Blue;
            initial3 = Console.ReadLine();
            //initial3 = (char)Console.Read();
            // Console.ReadKey(true);


            plrInitls = ($"{initial1}.{initial2}.{initial3}.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //m3
        static void WriteScoreInitals()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("High Scores ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{newScore} ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"- ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(plrInitls);

            Console.ForegroundColor = ConsoleColor.White;
        }

        //m9

        static void wtFile()
        {

            try
            {
                File.WriteAllText(filePath, scoreData);
         
                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        //m7
        static void rfFile()
        {
            try
            {
                File.ReadAllText(filePath);
                Console.WriteLine("Data recovered successfully.");
                Console.WriteLine(scoreData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        //m10
        static void scoreList()
        {

            List<string> ScoreInfo = new List<string>();


            for (int i = 0; i < 1; i++)
            {

                ScoreInfo.Add(scoreData);

                Console.WriteLine($"Generated score: {scoreData}. Added to list.");
            }

            Console.WriteLine("\n--- All scores have been added. ---\n");


            foreach (string score in ScoreInfo)
            {
                // Console.WriteLine(score);

                try
                {
                    File.WriteAllText(filePath, scoreData);
        
                    Console.WriteLine("Data saved successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }


    
}

        



