using System;

namespace _9Inheritance
{
    //INHERITANCE
    //Inheritance allows a class to "inherit" or use the properties, methods,
    //and behavior defined by another class.

    //We generally think of inheritance as representing an "is a" or "is a kind of"
    //relationship. For example, a Dog is an Animal, a Toyota Corolla is a Car,
    //and a Dresser is a kind of Furniture.
    public class Insect { /*...*/ }
    public class Bee : Insect { /*...*/ }

    public class Car { /*...*/ }
    public class ToyotaCorolla : Car { /*...*/ }

    public class Furniture { /*...*/ }
    public class Dresser : Furniture { /*...*/ }

    //You can have multiple classes inherit from a single base class.
    //In the below classes, both Dog and Wolf inherit from the Animal class.
    public class Animal //Base class
    {
        public string SpeciesName { get; set; }
        public bool IsDomesticated { get; set; }

        public virtual void MakeSound() 
        {
            Console.WriteLine("Basic Animal Sound");
        }
    }

    public class Dog : Animal //Derived class
    {
        public string BreedName { get; set; }

        public Dog(string breedName)
        {
            SpeciesName = "Canis familiaris";
            IsDomesticated = true;
            BreedName = breedName;
        }

        public override void MakeSound() 
        {
            Console.WriteLine("Bark!");
        }
    }

    public class Wolf : Animal //Derived class
    {
        public Wolf()
        {
            SpeciesName = "Canis lupus";
            IsDomesticated = false;
        }

        public override void MakeSound() 
        {
            Console.WriteLine("Awooooooooo!");
        }
    }

    //ACCESS MODIFIERS
    //As we learned in Part 7 - Classes, a C# class may have an access modifier (e.g. public, private, etc.)
    //Properties marked as private are not accessible in derived classes.
    public class Animal2
    {
        private string SpeciesName;
        protected bool IsDomesticated { get; set; }
        public bool IsExtinct { get; set; }
    }

    public class Dodo : Animal2
    {
        //We cannot access SpeciesName here, because it is private.
        //However, we CAN access IsDomesticated, because it is protected.
        //Protected properties in base classes can be accessed in derived classes.
        public Dodo()
        {
            IsDomesticated = false;
            IsExtinct = true;
        }
    }

    //OVERRIDING MEMBERS
    public class Animal3
    {
        public virtual void MakeSound() { /*...*/ }
    }

    public class Tiger : Animal3
    {
        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }

    public class Hobbes : Animal3
    {
        public override void MakeSound()
        {
            Console.WriteLine("Denial springs eternal.");
        }
    }

    //BASE CONSTRUCTORS
    //If the base class has a constructor method, it can be called from the derived class's constructor
    //using the base keyword.
    public class Animal4
    {
        public string SpeciesName { get; set; }
        public Animal4(string speciesName)
        {
            SpeciesName = speciesName;
        }
    }

    public class BlueWhale : Animal4
    {
        public BlueWhale() : base("Balaenoptera musculus") { /*...*/ }
    }

    //IMPLICIT INHERITANCE
    //Remember from Part 1 of this series that all C# objects must inherit from
    //the common base class System.Object. This means that they can also use
    //all methods defined on that class.
    public class Vegetable { } //We create an instance of Vegetable in the Main method below.

    //NO MULTIPLE INHERITANCE
    //C# does not permit a single class to inherit from multiple other classes.
    //However, there are other ways to share behavior, as we will see in Part 10.

    class Program
    {
        static void Main(string[] args)
        {
            //ACCESS MODIFIERS
            //When we instantiate a Dodo, we cannot access the property SpeciesName, because it is private.
            //We also cannot access the property IsDomesticated, because it is protected.
            //We can only access IsExtinct, because that property is public.
            var dodo = new Dodo();
            dodo.IsExtinct = true;

            //IMPLICIT INHERITANCE
            //When we create a Vegetable, remember that Vegetable has no members.
            //And yet, it can still use all the members defined on System.Object.
            Vegetable myVegetable = new Vegetable();
            var stringDescription = myVegetable.ToString(); //Method implemented in System.Object
            Console.WriteLine(stringDescription);
            var type = myVegetable.GetType(); //Method implemented in System.Object
            Console.WriteLine(type);
        }
    }
}
