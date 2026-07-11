using System;

namespace Hw_9
{
    internal class Program
    {
        static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;

            if (b.CompareTo(max) > 0)
                max = b;

            if (c.CompareTo(max) > 0)
                max = c;

            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Max(5, 8, 3));
            Console.WriteLine(Max(2.5, 7.8, 1.2));
        }
    }
}