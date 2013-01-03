namespace RSDotNetClient.Domain
{
    public class Endpoint
    {
        public string InternalUrl { get; set; }
        public string PublicUrl { get; set; }
        public string Region { get; set; }
        public string TenantId { get; set; }
    }
}