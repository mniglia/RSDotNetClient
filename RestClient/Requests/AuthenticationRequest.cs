namespace RSDotNetClient.RestClient.Requests
{
    public class AuthenticationRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }
        public string TenantId { get; set; }
        public string IdEndpoint { get; set; }
    }
}