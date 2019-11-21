using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_07.LINQ.Other_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ordering();
            //Aggregate();
            Partitioning();
        }
        static void Ordering()
        {
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names;
            descend.Sort();
            descend.Reverse();

            foreach( string name in descend )
            {
                Console.WriteLine($"{name}");
            }
            Console.Write("\n");

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> sorted = numbers;
            numbers.Sort();

            foreach( int number in sorted )
            {
                Console.WriteLine($"{number}");
            }
        }

        static void Aggregate()
        {
            // Output how many numbers are in this list
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine($"List has {numbers.Count} numbers.");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine($"We made ${purchases.Aggregate( 0.0, (sum, next) => sum+= next, total => total )}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            prices.Sort();
            prices.Reverse();
            Console.WriteLine($"Most expensive product costs: ${prices.GetRange(0,1)[0]}");
        }

        static void Partitioning()
        {
            /*
                Store each number in the following List until a perfect square is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            List<int> notPerfectSquare = wheresSquaredo.TakeWhile( number => RoundSquare(number) != number ).ToList();
            Console.WriteLine($"{notPerfectSquare.Count}");
            foreach( int number in notPerfectSquare )
            {
                Console.Write($"{number}, ");
            }
        }

        static int RoundSquare( int number )
        {
            return Convert.ToInt32(Math.Pow(Math.Round(Math.Sqrt(number)),2));
        }
    }
}