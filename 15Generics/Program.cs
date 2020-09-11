using System;

namespace _15Generics
{

    public class MyGeneric<T> { /*...*/ }

    class Program
    {
        static void Main(string[] args)
        {
            //GENERICS

            //A generic in C# is a type that can use objects of another type. We don't specify
            //the other type until the generic is used.

            //Class MyGeneric is defined earlier in this file.
            //Class OtherClass is defined in the OtherClasses.cs file
            var myGeneric = new MyGeneric<int>();
            var myOtherGeneric = new MyGeneric<OtherClass>();

            //Right now, this isn't very interesting; MyGeneric doesn't actually do anything yet.
            //The most common use for generic types is creating special collection classes.
            //We're going to create one of those. 
            //Head over to StackQueue.cs to continue.


            //RESUME
            //Because StackQueue is a generic class, we defer specifying the type
            //until an instance of it is created.
            var myStackQueue = new StackQueue<int>(); //T is now int

            myStackQueue.Enqueue(1);
            myStackQueue.Push(2);
            myStackQueue.Push(3);
            myStackQueue.Enqueue(4); //At this point, the collection is { 3, 2, 1, 4 }

            Console.WriteLine(myStackQueue.Pop()); //3
            Console.WriteLine(myStackQueue.Pop()); //2

            //We will get a build error if we attempt to push or enqueue
            //an object that is not of the type the StackQueue instance wants.

            //Uncomment the below line to get a compilation error.
            //myStackQueue.Push("a string");

            //GO TO SwapMethods.cs to continue this lesson.

            int a = 5;
            int b = 3;
            SwapMethods.Swap<int>(ref a, ref b);
            Console.WriteLine(a + " " + b); //Output: 3 5
        }
    }
}
