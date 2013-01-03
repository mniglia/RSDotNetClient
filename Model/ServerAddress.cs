namespace RSDotNetClient.Domain
{
    public class ServerAddress
    {
        public AddressType Type { get; set; }
        public string IpAddress { get; set; }
        public int Version { get; set; }
    }
}