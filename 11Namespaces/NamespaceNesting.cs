//It is possible to create nested namespaces:

namespace N1
{
    class C1 { /*...*/ }

    namespace N2
    {
        class C2 { /*...*/ }
    }
}

//We can also add a namespace to an existing namespace by qualifying it
namespace N1.N2
{
    class C3 { /*...*/ }
}

//Now both C2 and C3 exist in the N1.N2 namespace.