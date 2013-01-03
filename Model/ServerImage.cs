using System.Collections.Generic;

namespace RSDotNetClient.Domain
{
    public class ServerImage
    {
        public string Id { get; set; }
        public List<ObjectLink> Links { get; set; }
    }
}