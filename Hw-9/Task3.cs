using System;
namespace Hw_9
{
    internal class Task3
    {
        static T Sum<T>(T[] array)
        {
            dynamic sum = 0;

            foreach (T item in array)
            {
                sum += item;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            Console.WriteLine(Sum(a));
        }
    }
}
