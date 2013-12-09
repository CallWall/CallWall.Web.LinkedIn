using System;
using System.Collections.Generic;
using CallWall.Web;

namespace CallWall.WebHost.Models
{
    public class OAuthAccountListItem 
    {
        public OAuthAccountListItem(IAccountConfiguration accountConfiguration, bool isActive)
        {
            Name = accountConfiguration.Name;
            Image = accountConfiguration.Image;
            Resources = accountConfiguration.Resources;
            IsActive = isActive;
        }

        public string Name { get; private set; }
        public Uri Image { get; private set; }
        public IEnumerable<IResourceScope> Resources { get; private set; }
        public bool IsActive { get; private set; }
    }
}