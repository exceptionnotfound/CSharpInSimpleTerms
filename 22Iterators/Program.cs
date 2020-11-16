using System;
using System.Collections.Generic;
using System.Linq;

namespace _22Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------The yield Keyword-----------------");
            // Display the Fibonacci sequence up to the tenth number.
            foreach (int i in Fibonacci(10))
            {
                Console.Write(i + " ");
            }
            Console.Write(Environment.NewLine);

            var someNumbers = SomeNumbers();

            string allNumbers = "";
            foreach(int number in someNumbers)
            {
                allNumbers += " " + number.ToString();
            }

            Console.WriteLine(allNumbers.Trim());
            Console.WriteLine("Average: " + someNumbers.Average());

            Console.WriteLine("---------------------Iterators---------------------");

            foreach (int number in OddSequence(3, 31))
            {
                Console.Write(number.ToString() + " ");
            }
            Console.Write(Environment.NewLine);

            MonthsOfTheYear months = new MonthsOfTheYear();

            foreach(var month in months)
            {
                Console.WriteLine(month);
            }

            Console.WriteLine("-----------------Generic Iterators-----------------");

            //We can also use iterators with generic collections.
            //We copied the StackQueue<T> class from 15Generics and included it in this project.
            //Have a look at it, then come back here.

            //Instantiate the collection
            var myStackQueue = new StackQueue<int>(); 
            
            //Populate the collection
            myStackQueue.Enqueue(1);
            myStackQueue.Push(2);
            myStackQueue.Push(3);
            myStackQueue.Enqueue(4); //At this point, the collection is { 3, 2, 1, 4 }

            //Iterate over the collection
            foreach(var item in myStackQueue)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static IEnumerable<int> Fibonacci(int length)
        {
            int a = 0, b = 1;
            for (int i = 0; i < length; i++)
            {
                yield return a;
                int c = a + b;
                a = b;
                b = c;
            }
        }

        public static IEnumerable<int> SomeNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 7;
            yield return 8;
            yield return 5;
        }

        public static IEnumerable<int> OddSequence(int firstNumber, int lastNumber)
        {
            // Yield odd numbers in the range.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 != 0)
                {
                    yield return number;
                }
            }
        }
    }
}
