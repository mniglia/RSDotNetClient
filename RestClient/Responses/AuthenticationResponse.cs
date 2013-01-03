using RSDotNetClient.Domain;

namespace RSDotNetClient.RestClient.Responses
{
    public class AuthenticationResponse
    {
        public Token AuthenticationToken { get; set; }
        public ServiceCatalog ServiceCatalog { get; set; }
        public User User { get; set; }
    }
}
