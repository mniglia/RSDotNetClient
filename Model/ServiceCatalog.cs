using System.Collections.Generic;

namespace RSDotNetClient.Domain
{
    public class ServiceCatalog
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Endpoint> Endpoints { get; set; }
        
    }
}