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
        static string plrInitls;// = input; //($"{initial1}.{initial2}.{initial3}.");
       // static string scoreData = ($"{hScore}, {plrInitls}");
        //static string initial1;
        //static string initial2;
        //static string initial3;
        //static char initial1;
        //static char initial2;
        //static char initial3;
        static string input;
       // static List<string> ScoreInfo = new List<string>();
        static string filePath = "Scores.txt";
        //static string hScore = newScore.ToString();
        static string Character = "Big Player 6";


        // static List<string> list;




        static void Main(string[] args)
        {
            NamespaceHUD();
            Thread.Sleep(2000);
            do
            { 

                genScore();
                Thread.Sleep(1000);
                Initials();
                Thread.Sleep(2000);
                WriteScoreInitals();
                Thread.Sleep(500);
                //Console.ForegroundColor = ConsoleColor.DarkYellow;
                //Console.WriteLine("press any Key to save scores");
                //Console.ReadKey(true);
                Thread.Sleep(1500);
                wtFile();
                //Console.ForegroundColor = ConsoleColor.DarkYellow;
                //Console.WriteLine("press any Key to write scores to screen");
                //Console.ReadKey(true);
                Thread.Sleep(1500);
                rfFile(filePath);

                //ReadFileAndSortByScore(filePath);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Do you want to exit? Type y for yes then press enter, press any other key to continue.");
                
                Console.ForegroundColor = ConsoleColor.Red;
                input = Console.ReadLine();
                                
                Console.WriteLine(input);

                Console.ForegroundColor = ConsoleColor.DarkYellow;

            }
            
            while (input != null && input.ToLower() != "y");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Exiting program...");






        }
        //methods below

        //m7
       static void NamespaceHUD()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What is your character's name");
            Console.ForegroundColor = ConsoleColor.Blue;
            Character = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Hi ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{Character} ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("today you've played a fun game of....");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Space Invaders");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(", or maybe it was");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Bonk's Adventures");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("... though I think it's safe to  say it was definately NOT ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Keith Courage in Alpha Zones");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" (nobody remembers the TurboGrafx-16).\n you did well it is now time to see your score.");

        }


        //m8

        static void genScore()
        {
            newScore = random.Next(1, 1001);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($" score:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(newScore);
           // Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.White;
        }


        //m2
        static void Initials()
        {
            string input;
            bool isValid = false;
            
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Please your 3 initials");
                Console.ForegroundColor = ConsoleColor.Blue;
                input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (input != null && input.Length == 3)
                {
                    isValid = true;
                    Console.WriteLine("Thanks for the input.");
                    plrInitls = input;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(plrInitls);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Did you fail kindergarden? Maths is not your strong suit. \nPlease try again and remember... \nOne plus one plus one equals three.");
                    Console.ResetColor();
                }

            } while (!isValid);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Please enter your First inital and press enter");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //initial1 = Console.ReadLine();
            ////initial1 = (char)Console.Read();
            ////Console.ReadKey(true);

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Please enter your Second inital and press enter");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //initial2 = Console.ReadLine();
            ////initial2 = (char)Console.Read();
            //// Console.ReadKey(true);

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Please enter your Third inital and press enter");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //initial3 = Console.ReadLine();
            ////initial3 = (char)Console.Read();
            //// Console.ReadKey(true);


            //plrInitls = ($"{initial1}.{initial2}.{initial3}.");
            //Console.ForegroundColor = ConsoleColor.White;
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
           // string filePath = "Scores.txt";
           // string scoreData = ($"{hScore}, {plrInitls}");
            try
            {
             
                File.AppendAllText(filePath, ($"{newScore}, {plrInitls}") + Environment.NewLine);
                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        //m7
        static void rfFile(string filePath)
           


        {
           // string filePath = "Scores.txt";
            try
            {
                string fileContents = File.ReadAllText(filePath);

                Console.WriteLine($"--- Contents of {filePath} ---");
                Console.WriteLine(fileContents);
                Console.WriteLine("--- End of file contents ---");


                //File.ReadAllText(filePath);
                //Console.WriteLine("Data recovered successfully.");
                // Console.WriteLine(scoreData);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file '{filePath}' was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }


        //m11
        //cannot  get the sorting  figured out 

        //static void ReadFileAndSortByScore(string filePath)
        //{
        //    if (!File.Exists(filePath))
        //    {
        //        Console.WriteLine($"Error: The file '{filePath}' does not exist.");
        //        return;
        //    }

        //        string[] lines = File.ReadAllLines(filePath);

        //        var sortedScores = lines
        //        .Select(line =>
        //        {
                    
        //            var parts = line.Split(',');
        //            if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int score))
        //            {
        //                return new { Score = score, Line = line };
        //            }
        //            return new { Score = 0, Line = line }; 
        //        })
               
        //        .OrderByDescending(item => item.Score)
        //        .ToList(); 

           
        //    Console.WriteLine("--- High Scores (Highest to Lowest) ---");
        //    foreach (var item in sortedScores)
        //    {
        //        Console.WriteLine(item.Line);
        //    }
        //    Console.WriteLine("--- End of Scores ---");
        //}


    }


    
}

        



