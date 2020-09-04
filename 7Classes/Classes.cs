using System;
using System.Collections.Generic;
using System.Text;

namespace _7Classes
{
    //CLASSES
    //A class in C# is a definition that can be used to create *instances* of objects.

    class TestClass
    {
        //An empty, basic C# class
    }

    //MEMBERS
    //Classes can have *members*, which include:
    //Properties - provide a way to read, write, or change a value
    //Methods - A code block which can be invoked
    //Constructors - A special kind of method that sets the initial values of an instance

    //CLASS PROPERTIES
    //We define properties in a class by giving them a type.
    class ExampleClass
    {
        public string Property1;
        public int Property2; 
        public decimal Property3;
    }

    //The properties above each have an "access modifier" which tells the C# compiler
    //what kinds of objects can access that property.
    //"public" properties are accessible by any code.
    //"protected" properties are accessible by instances of this class and instances of classes
    //     which inherit from this class.
    //"private" properties are accessible only within this class.
    //"internal" properties are accessible from any code in the same assembly.
    //By default, all properties without an access modifier are private.

    //GETTER AND SETTER METHODS
    //In the ExampleClass above, the "properties" are actually *fields*.
    //Fields must be accessed directly. This is considered bad practice.
    //We can change fields to full properties by implementing getter and setter methods.
    class ExampleClass2
    {
        public string Property1 { get; set; }
        protected int Property2 { get; set; }
        private decimal Property3;
    }

    //To be clear: a "property" has either a getter or setter method, or both.
    //             a "field" has neither getter nor setter methods.

    //Note that Property3 above is a private field, and thus cannot have getter or setter methods.
    //If we want to allow access to private fields, we can declare a public property
    //and have the property's getter and setter methods access that field.
    class ExampleClass3
    {
        public string Property1 { get; set; }
        protected int Property2 { get; set; }
        private decimal Property3;

        public decimal PublicProperty3
        {
            get
            {
                return Property3;
            }
            set
            {
                Property3 = value;
            }
        }
    }

    //AUTO-IMPLEMENTED PROPERTIES
    //We can set up "auto-implemented" properties by using the { get; set; } syntax
    //on public and protected properties.
    class ExampleClass4
    {
        public string Property1 { get; set; }
        protected int Property2 { get; set; }
        public decimal Property3 { get; set; }
    }

    //The C# compiler will automatically make hidden private fields for 
    //each auto-implemented property. Plus it makes our code cleaner.
    //(Compare ExampleClass4 with ExampleClass3)

    //CALCULATED PROPERTIES
    //Properties in a class can reference other properties to get their value.
    //A specific form of this is calculated properties.
    class ExampleClass5
    {
        public string Property1 { get; set; }
        protected int Property2 { get; set; }
        public decimal Property3 { get; set; }

        public bool HasMoney
        {
            get
            {
                return Property3 > 0.0M;
            }
        }
    }

    //The calculated property HasMoney relies on the value of Property3.
    //Also, HasMoney does not have a setter method, since we cannot set its value.

    //CLASS ACCESS MODIFIERS
    //Classes, like properties, can have access modifiers applied to them.
    public class PublicClass { /*...*/ }
    class InternalClass { /*...*/ } //Default access modifier is internal

    //Classes which are declared directly as members of a namespace
    //must be public or internal. Internal is the default.

    //DERIVED CLASSES AND ACCESS MODIFIERS
    //A base class (that is, a class which has other classes inheriting from it)
    //cannot be less accessible than its base class.
    internal class ClassA { /*...*/ }

    //Uncomment the below line to get a compilation error.
    //public class ClassB : ClassA { /*...*/ }

    //METHODS
    //Classes can have methods, which can be invoked on instances of the class.
    public class ClassC
    {
        public string Property1 { get; set; }

        public void Method1() { /*...*/ }

        public string MethodWithReturn()
        {
            /*...*/
            return "stringValue";
        }
    }

    //Methods may also have return types and parameters.
    public class ClassD
    {
        public string MethodWithParameters(int param1, string param2, decimal param3)
        {
            return (param1 + param3).ToString() + " " + param2;
        }
    }

    //CONSTRUCTORS
    //Constructors are special methods in a class which are called when
    //an instance of the class is created. Constructors specify the starting
    //values of a class's properties.
    //The constructor has the same name as the class and no return type.
    public class ClassE
    {
        public ClassE() { /* Constructor Method */ }
    }

    public class ClassF
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }

        public ClassF(int param1)
        {
            Property2 = param1;
        }

        public ClassF(string param1)
        {
            Property1 = param1;
        }

        public ClassF(string param1, int param2)
        {
            Property1 = param1;
            Property2 = param2;
        }
    }

    //IMPLICIT CONSTRUCTOR
    //If we do not specify a constructor method for class, the compiler
    //we create an implicit constructor.
    //This kind of constructor is also called a public parameterless constructor,
    //because it will be public and have no parameters.
    public class ClassG
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }

        //Invocation in the Program.cs file.
    }

    //We can also set up a public parameterless constructor explicitly:
    public class ClassH
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }

        public ClassH() { /* Public parameterless constructor */ }
    }


}
