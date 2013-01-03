namespace RSDotNetClient.Domain
{
    public class ServerState
    {
        public string DiskConfig { get; set; }
        public string PowerState { get; set; }
        public string TaskState { get; set; }
        public string VmState { get; set; }
    }
}