namespace RSDotNetClient.RestClient.Requests
{
    public class AuthenticationRequest
    {
        //{"auth":{"RAX-KSKEY:apiKeyCredentials":{"username":"spinsolutions", "apiKey":"15f3ad2d1de2e9dcd3050d772348cce6"}}}
        
        public string Username { get; set; }
        public string Password { get; set; }
        //public string ApiKey { get; set; }
        //public string TenantId { get; set; }
        //public string IdEndpoint { get; set; }

        public string ToJson()
        {
            return string.Format("{{\"auth\":{{\"RAX-KSKEY:apiKeyCredentials\":{{\"username\":\"{0}\", \"apiKey\":\"{1}\"}}}}}}", 
                Username, Password);
        }
    }


}