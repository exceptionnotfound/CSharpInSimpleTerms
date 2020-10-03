using System;
using System.Collections.Generic;
using System.Text;

namespace _17AttributesAndReflection
{
    [AttributeUsage(AttributeTargets.Class
                    | AttributeTargets.Interface, Inherited = true, AllowMultiple = false)]
    public class AuthorInformationAttribute : Attribute
    {
        public int YearPublished { get; set; }
        public string AuthorName { get; set; }

        public AuthorInformationAttribute(int year)
        {
            YearPublished = year;
        }

        public AuthorInformationAttribute(string name, int year)
        {
            AuthorName = name;
            YearPublished = year;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class YearReviewedAttribute : Attribute
    {
        public int YearReviewed { get; set; }

        public YearReviewedAttribute(int year)
        {
            YearReviewed = year;
        }
    }
}
