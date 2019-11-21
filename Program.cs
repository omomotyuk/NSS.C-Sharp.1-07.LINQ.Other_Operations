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
            Aggregate();
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
    }
}