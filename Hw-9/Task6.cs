using System;
using System.Collections.Generic;


namespace Hw_9
{
    internal class Task6
    {
        static List<T> FilterByTwoCriteria<T>(List<T> list, Predicate<T> p1, Predicate<T> p2)
        {
            List<T> result = new List<T>();

            foreach (T item in list)
            {
                if (p1(item) && p2(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        static void Main()
        {
            List<int> numbers = new List<int>()
            {
                2,4,5,8,10,15
            };

            List<int> result = FilterByTwoCriteria(
                numbers,
                x => x > 5,
                x => x % 2 == 0);

            foreach (int item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            List<string> words = new List<string>()
            {
                "apple",
                "cat",
                "banana",
                "dog"
            };

            List<string> result2 = FilterByTwoCriteria(
                words,
                x => x.Length > 3,
                x => x.Contains("a"));

            foreach (string item in result2)
            {
                Console.Write(item + " ");
            }
        }
    }
}
