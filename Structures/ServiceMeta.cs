namespace ServiceNetwork.Structures
{
    public class ServiceMeta
    {
        public string Id { get; set; }

        public string Version { get; set; } = "1.0.0";

        public ServiceRequirement[] Requirements { get; set; } = null;
    }
}
