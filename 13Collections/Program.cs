using System;

//COLLECTIONS

//A collection in C# is similar to an array, but with a crucial difference.
//Arrays are great for dealing with groups of objects of a known size.
//Collections are great when we don't know how many objects we will need.

//NAMESPACE

//In order to use collections, we need to include the System.Collections.Generic namespace.
using System.Collections.Generic;

namespace _13Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIST<T>

            //The most common kind of collection in C# is List<T>.
            //T is a placeholder for a type; we will discuss this more in Part 15 Generics.
            //When we create an object of type List<T>, we need to specify what type T will be.

            List<int> numbers = new List<int>();
            List<string> names = new List<string>();

            Console.WriteLine();
            Console.WriteLine("---------------------Initializing List<T>----------------------");
            Console.WriteLine();

            //Just like with arrays, we can initialize a List<T> by giving its elements.
            List<int> years = new List<int> { 2020, 2019, 2018, 2017, 2016 };

            //Foreach loops (from Part 5 Basic Statements and Loops) enable us to
            //access each element in the collection.
            foreach (var year in years)
            {
                Console.WriteLine(year.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("---------------------Array-Style Indexing----------------------");
            Console.WriteLine();

            //We can also access individual elements using array-style indexing.
            List<string> daysOfTheWeek = new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            Console.WriteLine(daysOfTheWeek[3]); //"Thu"

            Console.WriteLine();
            Console.WriteLine("---------------------Add() Method----------------------");
            Console.WriteLine();

            //Finally, we can add elements to a List<T> using the Add method.
            List<string> daysOfTheWeek2 = new List<string>();
            daysOfTheWeek2.Add("Sun");
            daysOfTheWeek2.Add("Mon");
            daysOfTheWeek2.Add("Tue");
            daysOfTheWeek2.Add("Wed");
            daysOfTheWeek2.Add("Thu");
            daysOfTheWeek2.Add("Fri");
            daysOfTheWeek2.Add("Sat");

            foreach(var day in daysOfTheWeek2)
            {
                Console.WriteLine(day);
            }

            //METHODS

            Console.WriteLine();
            Console.WriteLine("---------------------List Methods----------------------");
            Console.WriteLine();

            //C# provides us with many methods on the List<T> type to help us manipulate the collection.

            //The names collection is defined earlier in this file.

            names.Add("test name"); //Adds new elements
            names.Add("second name");
            names.Add("third name");

            bool exists = names.Contains("test name"); //Checks if a particular value 
                                                       //exists in the collection

            List<string> aFewNames = names.GetRange(0, 2); //Returns a copy List<T> 
                                                           //starting from position 0
                                                           //and getting the next 
                                                           //two elements

            names.Insert(2, "second and a half name"); //Inserts an element at
                                                       //the specified position

            int index = names.IndexOf("test name"); //Returns the zero-based index of the
                                                    //first instance of the element.

            names.Remove("test name"); //Removes the first occurrance 
                                       //of the specified element

            names.Clear(); //Removes all elements 

            //COMBINING LISTS

            Console.WriteLine();
            Console.WriteLine("---------------------Combining Lists----------------------");
            Console.WriteLine();

            //It's also possible to combine two collections into a single collection.
            //We do this using the AddRange method.

            List<string> names1 = new List<string> { "alex", "amy", "angela", "adam" };
            List<string> names2 = new List<string> { "brianna", "bob", "barb" };

            names1.AddRange(names2);
            foreach (var name in names1)
                Console.WriteLine(name);

            //OTHER COLLECTION TYPES

            //DICTIONARY<TKEY, TVALUE>

            Console.WriteLine();
            Console.WriteLine("---------------------Dictionary<TKey, TValue>----------------------");
            Console.WriteLine();

            //A Dictionary<TKey, TValue> is a set of values, where each value has a unique key.
            Dictionary<string, string> imageTypes = new Dictionary<string, string>();

            //imageTypes.Add("key", "value");
            imageTypes.Add("bmp", "Bitmap");
            imageTypes.Add("jpeg", "Joint Photographic Experts Group");
            imageTypes.Add("png", "Portable Network Graphics");
            imageTypes.Add("gif", "Graphics Interchange Format");

            foreach (var imageFormat in imageTypes)
                Console.WriteLine(imageFormat.Key + " - " + imageFormat.Value);

            //If we attempt to add a key that already exists in the dictionary,
            //the compiler will throw a runtime error.
            //Uncomment the below line and run this project to see this happen.
            //imageTypes.Add("jpeg", "JPEG"); //EXCEPTION

            //When retrieving values out of a dictionary, we use the key to get the value
            var value = imageTypes["png"];
            Console.WriteLine(value);

            //QUEUE<T>

            Console.WriteLine();
            Console.WriteLine("---------------------Queue<T>----------------------");
            Console.WriteLine();

            //A queue is an ordered collection with a first-in, first-out style. 
            //Elements are "enqueued" and "dequeued" to be added into and out of the collection, respectively.
            Queue<int> orders = new Queue<int>();
            orders.Enqueue(1);
            orders.Enqueue(2);
            orders.Enqueue(3);
            orders.Enqueue(4);

            Console.WriteLine(orders.Dequeue()); //1
            Console.WriteLine(orders.Dequeue()); //2

            //STACK<T>

            Console.WriteLine();
            Console.WriteLine("---------------------Stack<T>----------------------");
            Console.WriteLine();

            //A stack is a collection of elements with a last-in, first-out style.
            //So elements that were added to the collection first will be removed last.

            Stack<int> elements = new Stack<int>();
            elements.Push(1);
            elements.Push(2);
            elements.Push(3);
            elements.Push(4);

            Console.WriteLine(elements.Pop()); //4
            Console.WriteLine(elements.Pop()); //3
        }
    }
}
