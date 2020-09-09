//In this class, we are including two namespaces which just so happen to
//both have a class User.

using MyProject.DTOs;
using OtherAPI.Models;

namespace _11Namespaces
{
    class NamespaceAliases1
    {
        //If we want to use the User class as a property, we might try to do this:
        //(Comment out this line if you want to run this project)
        public User MyUser { get; set; }

        //However, as you can see, this will throw a compilation error. The C#
        //compiler does not know which User class this property refers to.

        //A better way is in the NamespaceAliases2.cs file.
    }
}
