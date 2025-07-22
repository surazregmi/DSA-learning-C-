using System;
using DSA_C_._01_Arrays;


  public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program to run:");
        Console.WriteLine("1. Find Minimum in Array");

        Console.WriteLine("2. Calculate Two sums leetcode [2,11,7,15] target 9");
        Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FindMinimum.Run();
                    break;
            case "2":
            int[] result = TwoSumLC.TwoSum();
                Console.WriteLine("Indices of the target sum are: [" + string.Join(", ", result) + "]");
                break;
            default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
