using System;

namespace _21Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Indexers-------------------------");

            IntMathCollection myInts = new IntMathCollection();
            Console.WriteLine("Mean: " + myInts.Mean());
            Console.WriteLine("Median: " + myInts.Median());
            Console.WriteLine("Mode: " + myInts.Mode());

            //We can now access individual elements of this array using the indexer
            //created in the IntMathCollection class

            Console.WriteLine("Element at position 67 is " + myInts[67]);
            Console.WriteLine("Element at position 813 is " + myInts[813]);
            Console.WriteLine("Element at position 490 is " + myInts[490]);

            Console.ReadLine();
        }
    }
}
