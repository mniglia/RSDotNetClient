using System.Collections.Generic;

namespace RSDotNetClient.Domain
{
    public class ServiceCatalogItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Endpoint> Endpoints { get; set; }
    }
}