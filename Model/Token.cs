using System;

namespace RSDotNetClient.Domain
{
    public class Token
    {
        public string Id { get; set; }
        public DateTime Expires { get; set; }
        public Tenant Tenant { get; set; }
    }
}