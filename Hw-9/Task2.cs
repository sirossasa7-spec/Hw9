using System;

namespace Hw_9
{
    internal class Task2
    {
        static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a;

            if (b.CompareTo(min) < 0)
                min = b;

            if (c.CompareTo(min) < 0)
                min = c;

            return min;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Min(5, 8, 3));
            Console.WriteLine(Min(2.5, 7.8, 1.2));
        }
    }
}