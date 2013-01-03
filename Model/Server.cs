using System;
using System.Collections.Generic;

namespace RSDotNetClient.Domain
{
    public class Server
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Flavor { get; set; }
        public string AccessIpV4Address { get; set; }
        public string AccessIpV6Address { get; set; }
        public List<ServerAddress> Addresses { get; set; }
        public DateTime Created { get; set; }
        public ServerState State { get; set; }
        public string  HostId { get; set; }
        public ServerImage Image { get; set; }
        public List<ObjectLink> Links { get; set; }
        public ServerStatus Status { get; set; }
        public DateTime Updated { get; set; }
        public Dictionary<string, string> Metadata { get; set; }

    }
}