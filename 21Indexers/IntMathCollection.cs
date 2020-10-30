using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21Indexers
{
    public class IntMathCollection
    {
        private int[] _values = new int[1000];

        //We use the keyword *this* to create an indexer

        //Old style syntax
        //public int this[int i]
        //{
        //    get { return _values[i]; }
        //    set { _values[i] = value; }
        //}

        //New expression body syntax
        public int this[int i]
        {
            get => _values[i];
            set => _values[i] = value;
        }

        public IntMathCollection()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
        
            for(int i = 0; i< 1000; i ++)
            {
                _values[i] = rand.Next(1,1000);
            }
        }

        //To find the median, we order the values from least to greatest
        //and take the number in the middle position. Since the array
        //will have an even number of elements, we take the average of the
        //two numbers in the middle.
        public int Median()
        {
            var orderedValues = _values.ToList().OrderBy(x => x).ToArray();
            var value1 = orderedValues[499];
            var value2 = orderedValues[500];

            return (value1 + value2) / 2;
        }

        //The mean is a simple average, which LINQ can do for us.
        public double Mean()
        {
            return _values.ToList().Average();
        }

        //To find the mode, we first group the numbers by the count
        //of times they appear in the list, and then return the number
        //that appears the most times.
        //Implementation taken from StackOverflow: https://stackoverflow.com/a/8260598
        public int Mode()
        {
            return _values.GroupBy(v => v)
                          .OrderByDescending(g => g.Count())
                          .First()
                          .Key;
        }
    }
}
