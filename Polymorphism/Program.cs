using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            long myLong = 654321;
            byte myByte = (byte)myLong;
        }

        public static (double Average, int Min, int Max) GetStats(List<int> values)
        {
            return (values.Average(), values.Min(), values.Max());
        }

        public class Statistics
        {
            public double Average { get; set; }
            public int Min { get; set; }
            public int Max { get; set; }
        }

        public class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int BirthYear { get; set; }
        }
    }
}
