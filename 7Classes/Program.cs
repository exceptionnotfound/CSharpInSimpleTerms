using System;

namespace _7Classes
{
    class Program
    {
        //Go to Classes.cs to start this lesson
        static void Main(string[] args)
        {
            //We create instances of a class using the *new* keyword
            var myInstance = new TestClass();

            //When we initialize a class, the properties get the default value for their type.
            var myClass = new ExampleClass();
            Console.WriteLine(myClass.Property1); //Null
            Console.WriteLine(myClass.Property2); //0
            Console.WriteLine(myClass.Property3); //0.0

            //CONSTRUCTORS
            var myClassF = new ClassF("stringValue");
            var otherClassF = new ClassF("stringValue", 6);

            //IMPLICIT CONSTRUCTORS
            var myClassG = new ClassG();
        }
    }
}
