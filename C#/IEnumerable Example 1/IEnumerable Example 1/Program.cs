using System;
using System.Collections.Generic;

namespace IEnumerable_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //So the IEnumerable is a high class object type that can hold all generic collection, and it know which type.
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);
            Console.WriteLine(unknownCollection.GetType()); 
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            unknownCollection = GetCollection(2);
            Console.WriteLine(unknownCollection.GetType());
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            unknownCollection = GetCollection(3);
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            unknownCollection = GetCollection(4);
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

        }
        static IEnumerable<int> GetCollection(int option)
        {

            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numberQueue = new Queue<int>();
            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            Stack<int> numberStack = new Stack<int>();
            numberStack.Push(11);
            numberStack.Push(12);
            numberStack.Push(13);
            numberStack.Push(14);
            numberStack.Push(15);
            if (option ==1)
            {
                return numbersList;
            }
            else if (option ==2)
            {
                return numberQueue;
            }
            else if (option ==3)
            {
                return numberStack;
            }
            else
            {
                return new int[] { 16,17,18,19,20};
            }
                
            
            
        }
    }
}
