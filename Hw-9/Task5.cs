using System;
using System.Collections.Generic;

namespace Hw_9
{
    class MyQueue<T>
    {
        private List<T> list = new List<T>();

        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public T Dequeue()
        {
            T item = list[0];
            list.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            return list[0];
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
    internal class Task5
    {
        static void Main()
        {
            MyQueue<string> queue = new MyQueue<string>();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
        }
    }
}
