using System;

namespace _9Polymorphism
{
    //POLYMORPHISM

    //Polymorphism, along with encapsulation and inheritance, form the
    //three main "pillars" or characteristics of object-oriented programming.

    //Polymorphism in C# means we can treat an instance of a derived class
    //as though it is an instance of its base class.
    //(See Part 9 - Inheritance if you don't know what "base" and "derived" classes are)

    public class Animal //Base class
    {
        public string SpeciesName { get; set; }
        public string CommonName { get; set; }
    }

    public class Elephant : Animal { /*...*/ } //Derived class

    public class Porcupine : Animal //Derived class
    {
        public string OrderType { get; set; } //Old world or New world
    }
    //We also have the static method GetAnimalDetails, which is defined in StaticMethods.cs

    class Program
    {
        static void Main(string[] args)
        {
            //Let's say we instantiate an Elephant object.
            //When we do, because of inheritance, we can set both the SpeciesName
            //property and the CommonName property, because both are defined in the
            //base Animal class.
            var myElephant = new Elephant()
            {
                SpeciesName = "Loxodonta africana",
                CommonName = "African Elephant"
            };

            //Let's also create a new world porcupine
            var myPorcupine = new Porcupine()
            {
                OrderType = "New World",
                SpeciesName = "Erethizon dorsatum",
                CommonName = "North American Porcupine"
            };

            //If we pass these instances to the GetAnimalDetails method, it will treat
            //each of them as though they are instances of the Animal class.
            //This is because of Polymorphism.
            var elephantDetails = StaticMethods.GetAnimalDetails(myElephant);
            Console.WriteLine(elephantDetails);

            var porcupineDetails = StaticMethods.GetAnimalDetails(myPorcupine);
            Console.WriteLine(porcupineDetails);

            //VIRTUAL METHODS

            //The classes for this section are defined near the end of this file.

            var myFox = new Fox();
            myFox.Eat("rabbit"); //Output: "Chewing rabbit"
                                 //        "Digesting rabbit"

            var myAnteater = new Anteater();
            myAnteater.Eat("ants"); //Output: "Swallowing ants"

            //STOPPING VIRTUAL INHERITANCE

            //The classes used in this example are defined later in this file.
            A myA = new A();
            myA.GetDetails();

            B myB = new B();
            myB.GetDetails(); //Calls the implementation in B, which calls the implementation in A

            C myC = new C();
            myC.GetDetails(); //Calls the implementation in C, which calls the implementation in A

            E myE = new E();
            myE.GetDetails(); //Calls the implementation in E

            //FUN WITH POLYMORPHISM
            var dolphin = new Dolphin()
            {
                DolphinType = "Bottlenose"
            };

            var elephant = new Elephant2()
            {
                ElephantType = "Asian"
            };

            FunWithPolymorphism.OutputType(elephant);
            FunWithPolymorphism.OutputType(dolphin);

            Console.ReadLine();

        }
    }

    //VIRTUAL METHODS

    //We can work with polymorphism by implementing virtual methods.
    //Virtual methods define a behavior on a base class, but allow
    //for that behavior to be overridden by derived classes.
    public class Animal2
    {
        public virtual void Eat(string meal)
        {
            Console.WriteLine("Digesting " + meal);
        }
    }

    public class Fox : Animal2
    {
        public override void Eat(string meal)
        {
            Console.WriteLine("Chewing " + meal);
            base.Eat(meal);
        }
    }

    public class Anteater : Animal2 //They have no teeth!
    {
        public override void Eat(string meal)
        {
            Console.WriteLine("Swallowing " + meal);
            //NOTE: no call to base class here!
        }
    }

    //VIRTUAL PROPERTIES

    //We can also have properties defined on the base class that can be
    //overridden on derived classes.
    //Virtual methods and virtual properties allow developers to 
    //extend behavior without needing to change the behavior
    //of the base class.
    public class Animal3
    {
        public virtual int YearDiscovered
        {
            get { return int.MaxValue; } //Unknown year
        }
    }
    public class VibraniumFairyWrasse : Animal3
    {
        public override int YearDiscovered
        {
            get { return 2019; }
        }
    }

    //STOPPING VIRTUAL INHERITANCE

    //It is possible to prevent a derived class from overriding a virtual method or property.
    //Let's see a simple base and derived class.
    public class A
    {
        public virtual void GetDetails() 
        {
            Console.WriteLine("A.GetDetails invoked!");
        }
    }

    public class B : A
    {
        public override void GetDetails()
        {
            Console.WriteLine("B.GetDetails invoked!");
            base.GetDetails();
        }
    }

    //If we want to stop further derived classes from being able to
    //override the GetDetails method, we can mark it as sealed.
    public class C : A
    {
        public sealed override void GetDetails() 
        {
            Console.WriteLine("C.GetDetails invoked!");
            base.GetDetails();
        }
    }

    //In this way, any further derived classes cannot override this virtual method.
    public class D : C
    {
        //We cannot override GetDetails()!
    }

    //However, we can also create a new version of the member,
    //with its own implementation.
    public class E : C
    {
        public new void GetDetails()
        {
            Console.WriteLine("E.GetDetails invoked!");
        }
    }

    //Go to the Main method for an example on how to use this.
}
