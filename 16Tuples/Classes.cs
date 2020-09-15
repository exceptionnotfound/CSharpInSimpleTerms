using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16Tuples
{
    public class Statistics
    {
        public double Average { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static Statistics GetStats(List<int> values)
        {
            Statistics stats = new Statistics();
            stats.Average = values.Average();
            stats.Min = values.Min();
            stats.Max = values.Max();

            return stats;
        }

        public static (double Average, int Min, int Max) GetTupleStats(List<int> values)
        {
            return (values.Average(), values.Min(), values.Max());
        }
    }

}
