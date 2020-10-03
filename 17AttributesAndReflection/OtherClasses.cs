using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _17AttributesAndReflection
{
    [Serializable]
    public class SerializableClass { /*...*/ }

    [AuthorInformation("Miguel de Cervantes", 1605)]
    public class DonQuixote { /*...*/ }

    [AuthorInformation(1706)] //Rough date of first English-language publication
    public class OneThousandAndOneNights { /*...*/ }

    public class ReflectedClass
    {
        [YearReviewed(2019)]
        public string Property1 { get; set; }

        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}
