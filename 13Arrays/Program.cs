using System;

namespace _13Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS

            //An array is a collection of objects of the same type.
            //Each object in the array is called an "element".

            //We declare an array by specifying the type of the elements in that array.
            int[] numbers;

            //This array has no elements and no defined size. We can create a
            //new, single-dimensional array using the *new* keyword and
            //specifying a size.
            int[] numbers2 = new int[5];

            //For a single-dimensional array, we "initialize" the array
            //by giving it a set of values.
            //In the below example, the size of the array is determined
            //by the number of elements given.
            int[] numbers3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //We can also make our code more concise and avoid using *new*
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            //To get a specific element out of the array, we specify that
            //element's index. Arrays start numbering at 0, so if you want
            //the first element in the array, your index is 0.
            var month = months[0]; //"Jan"
            var month2 = months[6]; //"Jul"

            //MULTI-DIMENSIONAL ARRAYS

            //A two-dimensional (or 2D) array is an array of arrays.
            //We can declare a 2D array by specifying the dimensions:
            int[,] values = new int[5, 2]; //Holds 2 groups of 5 objects

            //We can also initialize a multi-dimensional array:
            //The below line creates a 3 x 4 multi-dimensional array
            int[,] myNumbers = new int[,] { { 5, 2, 6, 4 }, { 1, 8, 9, 2 }, { 9, 3, 4, 2 } };

            //Note that the multi-dimensional array's size is inferred from the values provided.

            //ACCESSING ELEMENTS

            //We can access elements in a multi-dimensional array by specifying the
            //index for each dimension.
            var value = myNumbers[1, 3]; //2

            //RANGES

            Console.WriteLine("RANGES");
            Console.WriteLine();

            //In C# 8.0, we now have a way to get a subset of an array.
            //This is called a Range.

            //Let's imagine we have the following array of names.
            var names = new string[] { "Andy", "Brittany", "Charles", "Damian", "Etan", 
                                       "Franklin", "Georgina", "Hasan", "Indira", "Jannelle" };

            //If we want to get the names starting with "Charles" and ending with "Hasan" we can
            //specify a range using the .. operator.
            var nameSubset = names[2..8];
            foreach (var name in nameSubset)
                Console.WriteLine(name);
            Console.WriteLine("--------------------------------------------");

            //We can also declare ranges as variables
            var range = 1..5;
            var nameSubset2 = names[range];
            foreach (var name in nameSubset2)
                Console.WriteLine(name);
            Console.WriteLine("--------------------------------------------");

            //OPEN-ENDED RANGES

            //We can get a range starting at a specific index and going to the end of the collection.
            var nameSubset3 = names[4..];
            foreach (var name in nameSubset3)
                Console.WriteLine(name);
            Console.WriteLine("--------------------------------------------");

            var nameSubset4 = names[..6];
            foreach (var name in nameSubset4)
                Console.WriteLine(name);

            //INDICES

            Console.WriteLine();
            Console.WriteLine("INDICES");
            Console.WriteLine();

            //We can get elements relative to the end of the list using the ^ operator.
            Console.WriteLine(names[^1]); //Jannelle
            Console.WriteLine(names[^3]); //Hasan
        }
    }
}
