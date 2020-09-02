using System;

namespace _1TypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //A type in C# is a specific set of properties about a kind of object.
            //For example, int is a type representing integers

            int four = 4;

            //Int values must be in the range -2^32 to (2^32 - 1); we know this 
            //because the int type defines it.

            //C# is a *strongly-typed* language. That means that every single object
            //MUST have a type.

            char a = 'a'; //char type
            decimal fivePointTwo = 5.2M; //decimal type
            object myObject = new object(); //object type
            MyClass myClass = new MyClass(); //MyClass type

            //C# is also a *type-safe* language. That means types can interact and be
            //combined in certain ways defined by the compiler.

            int five = 5;
            int ten = five + five; //No problem!

            //Uncomment the below line to get a compilation error.
            //int ten = five + "five";

            //Since no object can exist without a type, C# includes a "base" type
            System.Object myObject2 = new System.Object();
            object myObject3 = new object();

            //C# supports both *value types* and *reference types*
            //Value types have their value passed along with their instance.
            //Each of these are value types:
            int seven = 7;
            char b = 'b';
            double onePointThree = 1.3;

            //Reference types contain a reference to a location on the memory heap
            //which has the actual instance. String is a reference type, 
            //as are classes and collections.
            string referenceType = "My Reference Type";
            Array[] myArray = new Array[5];
            MyClass myClass2 = new MyClass();

            //C# supports the var keyword to allow us to use implicit types.
            //The type is inferred by the value of the object.
            var one = 1;
            var myDouble = 9.23;
            var myChar = 'l';
            var myArray2 = new Array[7];
            var myClass3 = new MyClass();

            //When using reference types, it is possible for there to not be a value
            //at the location referenced. When this happens, the value is said to be null.
            //When a reference type is instantiated, if not given a value, the value is null.

            string myNull; //Value is null
            MyClass myClass4; //Value is null

            //However, we cannot use var and assign the value to null.
            //Uncomment the below line to get a compilation error.
            //var myValue = null;

            Console.ReadLine();
        }
    }
}
