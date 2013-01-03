using System.Collections.Generic;

namespace RSDotNetClient.Domain
{
    public class User
    {
        public string DefaultRegion { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Role> Roles { get; set; }
    }
}