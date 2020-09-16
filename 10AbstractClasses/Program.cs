using System;

namespace _10AbstractClasses
{
    //ABSTRACT CLASSES

    //Abstract classes serve a similar purpose as interfaces: they allow us to have
    //multiple classes inherit a set of methods, properties, and other members.
    //An abstract class is defined using the *abstract* keyword.
    public abstract class Basic
    {
        //Members go here
    }

    //Methods in an abstract class can also be marked with the *abstract* keyword.
    //Such methods must not have an implementation, because the implementation
    //will be provided by the inheriting class.
    //Unlike interfaces, abstract classes may also have concrete methods with an implementation.
    public abstract class Gem
    {
        public abstract decimal GetValuePerCarat(); //Abstract method

        public string GetCommonColors() //Concrete method
        {
            return "Clear, Purple, Red, Black, White";
        }
    }

    //We can have other classes inherit from our abstract base class.
    //Extra special bonus points to whomever knows what these class names are from.
    public class Garnet : Gem
    {
        public override decimal GetValuePerCarat()
        {
            return 500M;
        }
    }

    public class Amethyst : Gem
    {
        public override decimal GetValuePerCarat()
        {
            return 300M;
        }
    }

    public class Pearl : Gem
    {
        public override decimal GetValuePerCarat()
        {
            return 400M;
        }
    }

    //If our derived class does not implement an abstract method, we get
    //a compilation error.

    //Uncomment the below class to see this.
    //public class Peridot : Gem { }

    //ABSTRACT PROPERTIES

    //Properties in a class can also be marked abstract. The inheriting class
    //can then override the properties to provide their own implementation.
    public abstract class Mineral //Base class
    {
        public abstract double Hardness { get; }
    }

    public class Quartz : Mineral //Derived class
    {
        public override double Hardness
        {
            get { return 7.0; }
        }
    }

    public class Bismuth : Mineral //Derived class
    {
        public override double Hardness
        {
            get { return 2.25; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Abstract Basics--------------------");
            var garnet = new Garnet();
            var value = garnet.GetValuePerCarat(); //Defined in Garnet class
            Console.WriteLine("Garnet value per carat: " + value);
            var commonColors = garnet.GetCommonColors(); //Defined in Gem base class
            Console.WriteLine("All gems common colors: " + commonColors);

            //OTHER DETAILS
            //Like an interface, abstract classes cannot be instantiated directly.
            //If you uncomment the below line, you will get a compilation error.
            //var myGem = new Gem();

            //Also, because of polymorphism, an instance of a class derived from an abstract
            //can be treated as an instance of that abstract class.
            Mineral myMineral = new Bismuth();
            var hardness = myMineral.Hardness;
        }
    }
}


//Go look at the Notes.cs file for additional information.