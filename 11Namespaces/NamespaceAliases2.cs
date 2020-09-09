//In this class, we introduce an alias "models" for the OtherAPI.Models namespace.

using models = OtherAPI.Models;
using MyProject.DTOs;

namespace _11Namespaces
{
    class NamespaceAliases2
    {
        //Here, we can use the models alias to specify which User class this should be.
        public models::User MyUser { get; set; }

        //And we no longer get a compilation error!
    }
}
