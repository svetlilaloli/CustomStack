using System;

namespace CustomStack
{
    public class Program
    {
        public static void Main()
        {
            SinglyLinkedStack<int> myStack = new SinglyLinkedStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            Console.WriteLine(myStack.Count);
            Console.WriteLine(myStack.Last);
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Count);
            Console.WriteLine(myStack.Last);
        }
    }
}
