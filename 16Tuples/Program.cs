using System;
using System.Collections.Generic;

namespace _16Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //TUPLES
            Console.WriteLine("-----------------------Tuples------------------------");

            //A tuple is a group of values gathered in a simple structure.
            //Unlike a collection (e.g. List<T>), a tuple is immutable
            //and of a fixed size.
            (double, int) myTuple = (8.2, 6);
            Console.WriteLine(myTuple);

            //C# provides a way to get the values out of a tuple
            //as though they are properties of a class
            Console.WriteLine(myTuple.Item1); //8.2
            Console.WriteLine(myTuple.Item2); //6

            //We can also provide names for the values inside a tuple
            (double Average, int Min, int Max) secondTuple = (4.5, 2, 17);
            Console.WriteLine("Average: " + secondTuple.Average.ToString()
                              + ", Max: " + secondTuple.Max.ToString()
                              + ", Min: " + secondTuple.Min.ToString());

            //WHY USE TUPLES?
            Console.WriteLine("--------------------Why Use Tuples?---------------------");

            //The most common use case for a tuple is as a return type from a method.
            //This is particularly useful if the method would otherwise return a class 
            //which might only be used in this one instance.

            //For example, let's say we have a collection of integers and want
            //to produce some simple statistics about said collection.
            //Class Statistics is defined in Classes.cs

            List<int> values = new List<int> { 6, 2, 7, 9, 2, 5, 3, 8, 10, 6 };

            var stats = Statistics.GetStats(values);

            Console.WriteLine("Average: " + stats.Average
                              + ", Max: " + stats.Max
                              + ", Min: " + stats.Min);

            //We can call the method GetTupleStats to get the statistics using tuples.
            var tupleStats = Statistics.GetTupleStats(values);

            Console.WriteLine("Average: " + tupleStats.Average
                                + ", Max: " + tupleStats.Max
                                + ", Min: " + tupleStats.Min);

            //Tuples allow us to, among other things, replace *out* parameters (See project 6Methods)
            //and can be used in place of anonymous types.

            //TUPLE ASSIGNMENT AND EQUALITY
            Console.WriteLine("------------Tuple Assignment and Equality-------------");

            //Just like other variables, tuples can be assigned to, provided the values match.
            (decimal, int) myTuple1 = (5.67M, 4);
            (decimal pricePerUnit, int units) myTuple2 = (1.1M, 1);

            myTuple2 = myTuple1;

            Console.WriteLine("Price per Unit: $" + myTuple2.pricePerUnit
                              + ", Units: " + myTuple2.units);

            //As of C# 7.3, we can also compare tuples using the == and != operators.
            (string, int) person1 = ("John Smith", 45);
            (string name, int age) person2 = ("Kayla Johnson", 52);

            Console.WriteLine(person1 == person2); //False
            Console.WriteLine(person1 != person2); //True

            //TUPLE DECONSTRUCTION
            Console.WriteLine("------------Tuple Deconstruction-------------");

            //Deconstructing tuples allows us to assign the values in the tuple to multiple individual variables.

            var person = ("John Smith", 45, 50000.00M); //Create a tuple
            (string name, int age, decimal salary) = person; //Deconstruct the tuple

            Console.WriteLine(name + ", age " + age + " makes $" + salary + "/year.");

            //We can also use the *var* keyword to let the compiler determine the types.
            var (name2, age2, salary2) = person;

            Console.WriteLine(name2 + ", age " + age2 + " makes $" + salary2 + "/year.");

            //We can even use existing variables.
            string name3;
            int age3;
            decimal salary3;
            (name3, age3, salary3) = person;

            Console.WriteLine(name3 + ", age " + age3 + " makes $" + salary3 + "/year.");
        }
    }
}
