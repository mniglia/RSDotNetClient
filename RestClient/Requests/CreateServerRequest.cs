using System.Collections.Generic;

namespace RSDotNetClient.RestClient.Requests
{
    public class CreateServerRequest
    {
        public string Name { get; set; }
        public string ImageRef { get; set; }
        public int FlavorRef { get; set; }
        public string DiskConfig { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public List<string> NetworkIds { get; set; }
    }
}
