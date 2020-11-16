using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _22Iterators
{
    public class MonthsOfTheYear : IEnumerable
    {
        private string[] _months = 
        { 
            "January", 
            "February", 
            "March", 
            "April", 
            "May",
            "June", 
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < _months.Length; index++)
            {
                // Yield each month of the year.
                yield return _months[index];
            }
        }
    }
}
