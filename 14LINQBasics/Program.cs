using System;
using System.Collections.Generic;
using System.Linq; //We must include this namespace in order to use LINQ.

namespace _14LINQBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHAT IS LINQ?
            Console.WriteLine("------------------What Is LINQ?-------------------");
            //LINQ provides a query syntax to allow us to query and manipulate
            //groups of objects.
            //There are two ways to use LINQ: a query syntax, and an API syntax.

            //Here's an example of the query syntax:
            List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var queryNumbers = from x in myNumbers
                              where x % 2 == 0
                              select x; //Get all even numbers

            foreach (var num in queryNumbers)
            {
                Console.Write(num.ToString() + " ");
            }
            Console.WriteLine();

            //Here's an example of the API syntax.
            var methodNumbers = myNumbers.Where(x => x % 2 == 0);

            foreach (var num in methodNumbers)
            {
                Console.Write(num.ToString() + " ");
            }
            Console.WriteLine();

            //In most situations, the API syntax will be more concise than the query syntax.
            //However, there are some queries that are easier to write using query syntax.

            //ANATOMY OF A QUERY
            Console.WriteLine("------------------Anatomy of a Query-------------------");
            //A basic LINQ query has three parts:
            //1. A *from* and *in* clause. The variable after *from* specifies a name for an iterator;
            //   think of it as representing each individual object in the collection.
            //   The *in* clause specifies the group or collection we are querying from.
            //2. An optional *where* clause. This uses the variable defined by the *from* clause
            //   to create conditions which must be true in order for an object to be 
            //   returned by the query.
            //3. A *select* clause. The *select* keyword specifies what parts of the object to select.

            //Let's create a collection of Users (User class defined in Classes.cs file).

            var users = new List<User>()
            {
                new User()
                {
                    FirstName = "Terrance",
                    LastName = "Johnson",
                    BirthYear = 2005
                },
                new User()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    BirthYear = 1966
                },
                new User()
                {
                    FirstName = "Eva",
                    LastName = "Birch",
                    BirthYear = 2002
                }
            };

            //We can now query this collection to get the full names of people
            //born in 1990 or later.
            var fullNames = from x in users
                            where x.BirthYear >= 1990
                            select new { x.FirstName, x.LastName };//Selecting a projection

            //This is an example of a projection. We can select properties of objects through LINQ
            //to construct projections of objects, as opposed to selecting the entire object.
            //When we iterate over this collection, only the properties we specified will be available.
            foreach(var name in fullNames)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }

            //For comparison, here's that same query using API syntax.
            var fullNamesMethodSyntax = users.Where(x => x.BirthYear >= 1990)
                                             .Select(x => new { x.FirstName, x.LastName });

            //FILTERING
            Console.WriteLine("-----------------------Filtering------------------------");

            //There are many ways to filter the results of a query other than using a *where* clause.

            //First() and FirstOrDefault()

            //For example, we may want the first object returned, or the first object returned
            //that matches a condition.

            //This method will throw an exception if no items are found.
            var first = users.First();

            //This method will throw an exception is no items that match the condition are found.
            var firstWithCondition = users.First(x => x.BirthYear > 2001);

            //If, instead of throwing an exception when no items are found, we want to return something,
            //we can return a default object using .FirstOrDefault()

            //First item in collection or default value
            var firstOrDefault = users.FirstOrDefault(); 

            //First object that matches a condition OR default value
            var firstOrDefaultWithCondition = users.FirstOrDefault(x => x.BirthYear > 2005);

            //Single() and SingleOrDefault()
            //We can also get exactly one item using Single() or SingleOrDefault()
            var singleUser = users.Single(x => x.FirstName == "John");

            var singleUserOrDefault = users.SingleOrDefault(x => x.LastName == "Johnson");

            //Both of the above methods will throw an exception if either no items are found
            //or more than one item is found.

            //Distinct()
            //Linq can also return all distinct items in a collection.
            Console.WriteLine("Distinct()");
            var indistinctNumbers = new List<int> { 4, 2, 6, 4, 6, 1, 7, 2, 7 };

            var distinctNumbers = indistinctNumbers.Distinct();
            foreach(var number in distinctNumbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            //ORDERING
            Console.WriteLine("-----------------------Ordering------------------------");

            //We can order results from a LINQ query by property values using the OrderBy() and ThenBy() methods.
            ///Same User class as earlier
            var orderedUsers = users.OrderBy(x => x.FirstName)
                                    .ThenBy(x => x.LastName); //Alphabetical order by first name,
                                                              //then last name

            Console.WriteLine("Alphabetical by first name");
            foreach(var user in orderedUsers)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + ", Born " + user.BirthYear);
            }

            //Note that we cannot use ThenBy() without using OrderBy() first.

            var descendingOrderUsers 
                = users.OrderByDescending(x => x.FirstName)
                       .ThenByDescending(x => x.LastName); //Reverse alphabetical order by
                                                           //first name, then 
                                                           //by last name

            Console.WriteLine();
            Console.WriteLine("Reverse alphabetical by first name, then last name");
            foreach (var user in descendingOrderUsers)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + ", Born " + user.BirthYear);
            }

            //If using query syntax, we order using the *order by* and *descending* keywords.
            var myUsers = from x in users
                          orderby x.BirthYear descending, x.FirstName descending
                          select x;

            //AGGREGATION
            Console.WriteLine("-----------------------Aggregation------------------------");

            //When operating on a collection of numbers, LINQ provides several aggregation methods.
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Sum: " + numbers.Sum()); //55

            Console.WriteLine("Min: " + numbers.Where(x=> x >= 2).Min()); //2
            Console.WriteLine("Max: " + numbers.Where(x => x < 7).Max()); //6

            //Returns the number of elements: 10 in this case
            Console.WriteLine("Count: " + numbers.Count());

            //Returns the average of numbers whose value is > 3. Result: 7
            Console.WriteLine("Average: " + numbers.Where(x => x > 3).Average());

            //METHOD CHAINING
            Console.WriteLine("-----------------------Method Chaining------------------------");

            //A few of the examples above (Min, Max, Average) use multiple LINQ methods to get their results.
            //The great thing about LINQ's API syntax is that you can chain multiple methods to make
            //concise, readable code.
            //For example, say we have a collection of users:
            var moreUsers = User.UserGenerator();  //Defined in Classes.cs

            //Let's say we want to get the first and last name of all users who have
            //a last name starting with 'J
            //who are born between 2000 and 2015, 
            //and want the result ordered alphabetically ordered by first name.
            //We can chain several methods we have already learned to create this query.

            var resultUsers = moreUsers.Where(x => x.LastName[0] == 'J'
                                                   && x.BirthYear >= 2000
                                                   && x.BirthYear <= 2015)
                                       .OrderBy(x => x.FirstName)
                                       .Select(x => x.FirstName + " " + x.LastName);

            foreach(var name in resultUsers)
            {
                Console.WriteLine(name);
            }

            //IENUMERABLE<T> AND CONVERSION
            Console.WriteLine("-----------------------IEnumerable<T> and Conversion------------------------");

            //When using LINQ, the return type from a query is often IEnumerable<T>. This is a generic
            //interface that collections implement in order to be enumerable, which means they can create
            //an iterator over the collection which can return individual elements from within it.

            //Much of the time, operating on an object of type IEnumerable<T> is just fine. We can 
            //use foreach loops and other LINQ methods on that type, or get projections out of it.

            //But sometimes, what we really want is a full-blown collection. For that, LINQ includes a set
            //of methods to convert to either an array or a List<T>.

            var evenNumbers = numbers.Where(x => x % 2 == 0); //Numbers defined in Aggregation section

            List<int> list = evenNumbers.ToList();

            int[] array = evenNumbers.ToArray();

            foreach(var number in list)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            //EXISTENCE OPERATIONS
            Console.WriteLine("-----------------------Existence Operations------------------------");

            //LINQ can check for the existence of a particular object in a collection.
            //For example, let's say we want to know if any users from the earlier collection resultUsers
            //were born in 1997.
            bool isAnyoneBornIn1997 = users.Any(x => x.BirthYear == 1997);
            Console.WriteLine("Anyone born in 1997? " + isAnyoneBornIn1997);

            //We can use the Any() method with no condition to see if any objects exist in a collection.
            var isAnyoneBornIn2002 = moreUsers.Where(x => x.BirthYear == 2002).Any();
            Console.WriteLine("Anyone born in 2002? " + isAnyoneBornIn2002);

            //We can also check if ALL the objects in a collection satisfy a condition.
            var isEveryoneBornIn1997 = moreUsers.All(x => x.BirthYear == 1997);
            Console.WriteLine("Is everyone born in 1997? " + isEveryoneBornIn1997);

            //We can even check if a collection contains a particular value
            List<int> newNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            bool hasAFive = newNumbers.Contains(5);
            Console.WriteLine("Does the collection have a 5? " + hasAFive);


            //SET OPERATIONS
            Console.WriteLine("-----------------------Set Operations------------------------");

            //LINQ allows us to perform set operations against two or more groups of objects.

            //INTERSECTION
            //An intersection is the group of objects that appear in both collections.
            var intersectionList1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var intersectionList2 = new List<int> { 2, 4, 6, 8, 10, 12, 14 };

            var intersection = intersectionList1.Intersect(intersectionList2); //{ 2, 4, 6, 8 }
            Console.Write("Intersection: ");
            foreach(var number in intersection)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //UNION
            //A union is a combined list of unique objects from two or more separate collections.
            //An element which appears in both of the source lists will only appear once in the union.
            var unionList1 = new List<int> { 5, 7, 3, 2, 9, 8 };
            var unionList2 = new List<int> { 9, 4, 6, 1, 5 };

            var union = unionList1.Union(unionList2); //{ 5, 7, 3, 2, 9, 8, 4, 6, 1 }
            Console.Write("Union: ");
            foreach(var number in union)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //EXCEPT
            //There is also the method Except(), which produces the elements that
            //are in the first set but not in the second set.
            var exceptList1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var exceptList2 = new List<int> { 7, 2, 8, 5, 0, 10, 3 };

            var except = exceptList1.Except(exceptList2); //{ 1, 4, 6, 9 }
            Console.Write("Except: ");
            foreach(var number in except)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //GROUPING
            Console.WriteLine("-----------------------Grouping------------------------");

            //Let's create a collection of Book objects (Book class defined in Classes.cs).
            var books = new List<Book>()
            {
                new Book()
                {
                    ID = 1,
                    Title = "Title 1",
                    AuthorName = "Author 1",
                    YearOfPublication = 2015
                },
                new Book()
                {
                    ID = 2,
                    Title = "Title 2",
                    AuthorName = "Author 2",
                    YearOfPublication = 2015
                },
                new Book()
                {
                    ID = 3,
                    Title = "Title 3",
                    AuthorName = "Author 1",
                    YearOfPublication = 2017
                },
                new Book()
                {
                    ID = 4,
                    Title = "Title 4",
                    AuthorName = "Author 3",
                    YearOfPublication = 1999
                },
                new Book()
                {
                    ID = 5,
                    Title = "Title 5",
                    AuthorName = "Author 4",
                    YearOfPublication = 2017
                },
            };

            //One query we might want to run against this collection is a query to list
            //each book in order by publication year. To do this, we need to group the Book objects.

            var results = from b in books
                          group b by b.YearOfPublication into g
                          orderby g.Key
                          select new { Year = g.Key, Books = g.ToList() };

            foreach (var result in results)
            {
                Console.WriteLine("Books published in " + result.Year.ToString());

                var yearBooks = result.Books;
                foreach (var book in yearBooks)
                {
                    Console.WriteLine(book.Title + " by " + book.AuthorName);
                }
            }
        }
    }
}
