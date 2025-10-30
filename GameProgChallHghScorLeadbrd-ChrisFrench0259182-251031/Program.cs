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
       //static string plrInitls = ($"{initial1}.{initial2}.{initial3}.");
        static string plrInitls;
        static string scoreData = ($"{hScore}, {plrInitls}");
        static string initial1;
        static string initial2;
        static string initial3;
        //static char initial1;
        //static char initial2;
        //static char initial3;

        static string filePath = "Scores.txt";
        static string hScore;
        static List<string> list;
        static void Main(string[] args)
        {
            //string initals = Initials();




           // List<string> hScore = GenerateScore();
            genScore();
            Thread.Sleep(1000);
           // List<string> initals = Initals();

           Initials();
            Thread.Sleep(3000);
            WriteScoreInitals();
            wtFile();
            rfFile();

           // SaveListToFile( filePath, List<string> hScore);
           // WriteFileToConsole( filePath);



        }
        //methods below
        ////m1
        //static List<string> GenerateScore()
        //{

        //    List<string> hScore = new List<string>();


        //    string Score = newScore.ToString();

        //    do
        //    {
        //        newScore = random.Next(1, 1001);
        //        if (!string.IsNullOrWhiteSpace(Score))
        //        {

        //            hScore.Add(Score);

        //        }
        //    } while (!string.IsNullOrWhiteSpace(Score));

        //    return hScore;


        //}


        ////m4
        ////static void Initals()
        //static List<string> Initals()
        //{
        //        List<string> initals = new List<string>();
        //        Console.WriteLine("Please enter 3 initals:");

        //        string input;

        //        do
        //        {
        //            input = Console.ReadLine();
        //            if (!string.IsNullOrWhiteSpace(input))
        //            {

        //                initals.Add(input);

        //            }
        //        } while (!string.IsNullOrWhiteSpace(input));

        //        return initals;

        //}


        ////m5
        //static void SaveListToFile(string filePath, /*List<string> hScore,*/ List<string> list)
        //{
        //    try
        //    {
        //        File.WriteAllLines(filePath, list);
        //       // Console.WriteLine($"{list.Count} Sets of Scores and Initals saved to {filePath}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error writing to file...");
        //    }
        //}

        ////m6
        //static void WriteFileToConsole(string filePath)
        //{
        //    if (File.Exists(filePath))
        //    {
        //        try
        //        {
        //           string[] lines = File.ReadAllLines(filePath);

        //            Console.ReadKey(true);
        //            foreach (string line in lines)
        //            {
        //                Console.WriteLine(line);
        //            }



        //            //foreach (string line in lines)
        //            //{
        //            //    Console.WriteLine(line);
        //            //}
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error reading from file");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"File {filePath} not found.");
        //    }
        //}

        //m7


        //m8





        static void genScore()
        {
            newScore = random.Next(1, 1001);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($" score:");
            Console.WriteLine(newScore);
            Console.ReadKey(true);

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
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your Second inital and press enter");
            Console.ForegroundColor = ConsoleColor.Blue;
            initial2 = Console.ReadLine();
            //initial2 = (char)Console.Read();
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your Third inital and press enter");
            Console.ForegroundColor = ConsoleColor.Blue;
            initial3 = Console.ReadLine();
            //initial3 = (char)Console.Read();
            Console.ReadKey(true);


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
            //Console.Write(initial2);
            //Console.Write(initial2);
            //Console.WriteLine(initial3);


            //foreach (string inital in initals)
            //{
            //    Console.WriteLine(inital);
            //}

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
       
        List<string> ScoreInfo = new List<string> { scoreData, };


            try
            {
                File.WriteAllLines(filePath, ScoreInfo);
                Console.WriteLine("List saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }


    }
}
