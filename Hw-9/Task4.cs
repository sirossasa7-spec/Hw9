using System;
using System.Collections.Generic;

namespace Hw_9
{
    class MyStack<T>
    {
        private List<T> list = new List<T>();

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }

        public T Peek()
        {
            return list[list.Count - 1];
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
    internal class Task4
    {
        static void Main()
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count);
        }
    }
}
