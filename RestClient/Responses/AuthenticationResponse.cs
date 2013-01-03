using System.Collections.Generic;
using RSDotNetClient.Domain;

namespace RSDotNetClient.RestClient.Responses
{
    public class AuthenticationResponse
    {
        public Access Access { get; set; }
    }

    public class Access
    {
        public Token Token { get; set; }
        public List<ServiceCatalog> ServiceCatalog { get; set; }
        public User User { get; set; }
    }

}
