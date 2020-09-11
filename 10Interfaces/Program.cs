using System;

namespace _10Interfaces
{
    //INTERFACES

    //Interfaces are special objects in C# that define a set of related
    //functionalities which may include methods or properties.
    //Think of interfaces as a *contract*, because when a C# class
    //implements an interface, they agree to implement each of the members
    //defined in said interface.
    //We identify interfaces by using the *interface* keyword.
    public interface IAreaCalculator
    {
        double GetArea();
    }
    //Note that the GetArea method has no definition. Because this is an
    //interface, we do provide an implementation here; that is the job
    //of any class which implements this interface.

    //Classes can now implement this interface and provide their own
    //implementation for each of the interface's members.
    public class Circle : IAreaCalculator
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }

    public class Rectangle : IAreaCalculator
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double GetArea()
        {
            return Height * Width;
        }
    }

    public class Triangle : IAreaCalculator
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double GetArea()
        {
            return Height * Width * 0.5;
        }
    }

    //Note that the implementing class must provide implementations for ALL
    //of the interface's members. If it does not, we get a compilation error.
    //Uncomment the below class to see this error.
    //public class Oval : IAreaCalculator
    //{
    //    public double Radius1 { get; set; }
    //    public double Radius2 { get; set; }
    //}


    //INTERFACE INHERITANCE

    //An interface can inherit, but only from other interfaces.
    //A single interface may inherit from as many other interfaces as it needs.
    public interface IMovement
    {
        public void Move();
    }

    public interface IMakeSound
    {
        public void MakeSound();
    }

    public interface IAnimal : IMovement, IMakeSound
    {
        string SpeciesName { get; set; }
    }

    //Any class or struct that inherits from an interface which is in turn inheriting
    //from other interfaces must provide an implementation for each property of *all* interfaces
    //it is implementing.
    public class Dog : IAnimal
    {
        public string SpeciesName { get; set; }

        public void MakeSound() //From IMakeSound
        {
            Console.WriteLine("Bark!");
        }

        public void Move() //From IMovement
        {
            Console.WriteLine("Running happily!");
        }
    }

    //A class can also implement as many interfaces as it needs, and must provide
    //implemention for all members found in those interfaces.

    public interface IAnimal2
    {
        string SpeciesName { get; set; }
    }

    public class Cat : IMovement, IMakeSound, IAnimal2
    {
        public string SpeciesName { get; set; }

        public void MakeSound() { /*...*/ }

        public void Move() { /*...*/ }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Interfaces cannot be instantiated directly, so lines such as
            //var myCalculator = new IAreaCalculator();
            //will not compile. However, due to polymorphism, we can treat
            //an instance of a class that implements an interface as though it is
            //an instance of the interface itself.
            IAreaCalculator myCalc = new Circle()
            {
                Radius = 2
            };
            double area = myCalc.GetArea(); //12.566
        }
    }
}

//In summary, interfaces allow us to define a set of methods and properties
//for which implementations will be provided by inheriting classes.