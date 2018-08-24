using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

// Find the words in the collection that start with the letter 'L'
        List<string> fruits = new List<string>()
        {
        "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"
        };

        IEnumerable<string> LFruits = from fruit in fruits
                                      where fruit.StartsWith("L")
                                      select fruit;

        foreach (var item in LFruits)
        {
            Console.WriteLine(item);
        }

 // Which of the following numbers are multiples of 4 or 6
            List<int> manyNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> multiplesOf = manyNumbers.Where(num => num % 4 == 0 || num % 6 == 0).ToList();
            foreach (int number in multiplesOf)
            {
                Console.WriteLine(number);
            }

// Order these student names alphabetically, in descending order (Z to A)
        List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

        List<string> descending = names.OrderByDescending(m => m).ToList();
            foreach (string item in descending)
            {
                Console.WriteLine(item);
            }

// Build a collection of these numbers sorted in ascending order
        List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };
        List<int> ascending = numbers.OrderBy(q => q).ToList();
        
            foreach (int item in ascending)
            {
                Console.WriteLine(item);
            }

// Output how many numbers are in this list
            List<int> numberList = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine(numberList.Count());

// How much money have we made?
            List<double> totalMoneyMade = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine($"{totalMoneyMade.Sum().ToString("C")}");

// What is our most expensive product?
            List<double> mostExpensive = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            Console.WriteLine($"{mostExpensive.Max().ToString("C")}");

/*
Store each number in the following List until a perfect square is detected.
Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            List<int> noSquare = wheresSquaredo.TakeWhile(k => Math.Sqrt(k) % 1 != 0).ToList();
            foreach (var item in noSquare)
            {
                Console.WriteLine(item.ToString());
            }

        
    }
}