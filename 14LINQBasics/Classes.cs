using System;
using System.Collections.Generic;
using System.Text;

namespace _14LINQBasics
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        public static List<User> UserGenerator()
        {
            return new List<User>
            {
                new User()
                {
                    FirstName = "Alex",
                    LastName = "Harcourt",
                    BirthYear = 1989
                },
                new User()
                {
                    FirstName = "Jill",
                    LastName = "Berrington",
                    BirthYear = 1973
                },
                new User()
                {
                    FirstName = "Jerry",
                    LastName = "North",
                    BirthYear = 1971
                },
                new User()
                {
                    FirstName = "Terrance",
                    LastName = "Johnson",
                    BirthYear = 2005
                },
                new User()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    BirthYear = 1966
                },
                new User()
                {
                    FirstName = "Eva",
                    LastName = "Birch",
                    BirthYear = 2002
                },
                new User()
                {
                    FirstName = "Tristan",
                    LastName = "Jones",
                    BirthYear = 2009
                }
            };
        }
    }

    public class Book
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int YearOfPublication { get; set; }
    }
}
