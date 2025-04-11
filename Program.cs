using System;

namespace APSCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Admission Point Score Calculator!");

            // Get subject scores and levels
            int[] subjectScores = new int[6];
            string[] subjectLevels = new string[6];
            string[] subjectNames = new string[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"\nEnter details for Subject {i + 1}:");

                Console.Write("Subject Name: ");
                subjectNames[i] = Console.ReadLine();

                int score;
                while (true)
                {
                    Console.Write("Subject Score (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
                    {
                        subjectScores[i] = score;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
                    }
                }
            }

            // Calculate APS
            int aps = CalculateAPS(subjectScores, subjectLevels);

            // Display the result
            Console.WriteLine("\n--------------------");
            Console.WriteLine("Subject Breakdown:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{subjectNames[i]}: Score = {subjectScores[i]}, Points = {GetLevelPoints(subjectScores[i])}");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine($"Your total Admission Point Score (APS) is: {aps}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static int CalculateAPS(int[] scores, string[] levels)
        {
            int totalPoints = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                totalPoints += GetLevelPoints(scores[i]);
            }
            return totalPoints;
        }

        static int GetLevelPoints(int score)
        {
             if (score >= 80)
            {
                return 7;
            }
            else if (score >= 70)
            {
                return 6;
            }
            else if (score >= 60)
            {
                return 5;
            }
            else if (score >= 50)
            {
                return 4;
            }
            else if (score >= 40)
            {
                return 3;
            }
            else if (score >= 30)
            {
                return 2;
            }
            else if (score >= 0 && score <= 100)
            {
                return 1;
            }
            else
            {
                Console.WriteLine($"Warning: Invalid score '{score}'. Points will be 0 for this subject.");
                return 0;
            }
        }
    }
}