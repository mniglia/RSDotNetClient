using System.Collections.Generic;
using RSDotNetClient.Domain;

namespace RSDotNetClient.RestClient.Responses
{
    public class CreateServerResponse
    {
        public string Id { get; set; }
        public string DiskConfig { get; set; }
        public string AdminPassword { get; set; }
        public List<ObjectLink> Links { get; set; }

    }
}
