//It may happen that we have two classes with the same name in different namespaces.
//We have defined such a situation below.

namespace OtherAPI.Models
{
    public class User { /*...*/ }
}

namespace MyProject.DTOs
{
    public class User { /*...*/ }
}


