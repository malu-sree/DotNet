using System;
using System.Collections.Generic;

namespace Generic
{
    class Stack<T>  
    {
        private List<T> elements = new List<T>();

        public void Push(T item)
        {
            elements.Add(item);
        }

        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            T result = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return result;
        }

        public T Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return elements[elements.Count - 1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine("Popped: " + intStack.Pop());
            Console.WriteLine("Popped: " + intStack.Pop());
            Console.WriteLine("Peek: " + intStack.Peek());

            Console.WriteLine();

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("One");
            stringStack.Push("Two");
            stringStack.Push("Three");
            Console.WriteLine("Popped: " + stringStack.Pop());
            Console.WriteLine("Popped: " + stringStack.Pop());
            Console.WriteLine("Peek: " + stringStack.Peek());

            Console.ReadLine(); 
        }
    }
}
