using System;

namespace RSDotNetClient.Domain
{
    public class Token
    {
        public DateTime Expires { get; set; }
        public string Id { get; set; }
        public Tenant Tenant { get; set; }
    }
}