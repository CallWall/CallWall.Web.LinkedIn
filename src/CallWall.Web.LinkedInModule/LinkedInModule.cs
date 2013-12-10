using CallWall.Web.LinkedInModule.Auth;
using CallWall.Web.LinkedInModule.Contacts;

namespace CallWall.Web.LinkedInModule
{
    public sealed class LinkedInModule : IModule
    {
        public void Initialise(ITypeRegistry registry)
        {
            registry.RegisterType<IContactsProvider, LinkedInContactsProvider>("LinkedInContactsProvider");
            registry.RegisterType<IAccountAuthentication, LinkedInAuthentication>("LinkedInAuthentication");
        }
    }
}