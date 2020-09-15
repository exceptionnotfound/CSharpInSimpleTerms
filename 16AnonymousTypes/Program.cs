using System;
using System.Collections.Generic;
using System.Linq;

namespace _16AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ANONYMOUS TYPES
            Console.WriteLine("------------------Anonymous Types------------------");

            //Anonymous types are similar to tuples (see project 16Tuples) but are used differently.
            //We instantiate an anonymous type using the var keyword.
            var myAnonymous = new { Name = "John Smith", Age = 4 };
            Console.WriteLine(myAnonymous);


            var users = new List<User>()
            {
                new User()
                {
                    Name = "Test User 1",
                    Age = 30,
                    DateOfBirth = new DateTime(1990, 5, 21)
                },
                new User()
                {
                    Name = "Test User 2",
                    Age = 55,
                    DateOfBirth = new DateTime(1965, 3, 10)
                }
            };

            //The most common scenario for anonymous types is in LINQ queries.
            //Specifically, LINQ projections:
            var results = users.Where(x => x.Age > 40)
                               .Select(x => new { x.Name, x.Age }); //Anonymous type

            foreach (var item in results)
            {
                Console.WriteLine("Name: " + item.Name + ", Age: " + item.Age);
            }

            //Anonymous types are immutable (their properties cannot be modified once created)
            //and they are not types in the traditional sense. Their type is generated
            //by the compiler. Consequently they come with some restrictions
            //1. Anonymous types cannot be used as parameters or return values (see 6Methods).
            //2. Anonymous types may only have properties; constructors or other methods are not permitted.
            //3. Anonymous types inherit from System.Object, and therefore cannot be cast to any other object.
        }
    }
}
