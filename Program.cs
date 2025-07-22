using System;
using DSA_C_._01_Arrays;


  public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. Find Minimum in Array");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FindMinimum.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
