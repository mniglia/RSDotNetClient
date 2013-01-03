using System.Collections.Generic;

namespace RSDotNetClient.RestClient
{
    public class ApiRequest
    {
        private readonly string _address;

        public ApiRequest(string address)
        {
            _address = address;
        }

        public Dictionary<string, string> Headers { get; set; }

    }
}
