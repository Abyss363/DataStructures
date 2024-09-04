using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures;

internal class Program
{
    public static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();
        Queue<string> myQueue = new Queue<string>();
        LinkedList<string> myList = new LinkedList<string>();

        Console.WriteLine(myStack.Size());
        myStack.Push(5);
        myStack.Push(9);
        myStack.Push(10);
        myStack.Pop();
        myStack.Peek();
        Console.WriteLine(myStack.IsEmpty());
        Console.WriteLine(myStack.Size() + "\n");

        Console.WriteLine(myQueue.Size());
        myQueue.Dequeue();
        myQueue.Enqueue("first");
        myQueue.Enqueue("second");
        myQueue.Enqueue("third");
        myQueue.Dequeue();
        Console.WriteLine(myQueue.IsEmpty());
        Console.WriteLine(myQueue.IsFull() + "\n");

        myList.Add("first");
        myList.Add("second");
        myList.Add("third");
        myList.Remove("second");
        Console.WriteLine(myList.Check("second"));
        Console.WriteLine(myList.Check("third"));
        Console.WriteLine(myList.Index("first"));
        Console.WriteLine(myList.Index("second"));

    }
}