using ServiceNetwork.Hub;
using ServiceNetwork.Structures;

namespace ServiceNetwork.Services
{
    public class TestService : Service
    {
        public override ServiceMeta Meta => new ServiceMeta() {
            Id = "test"
        };

        public override void Start()
        {
            Log.Write("Test service started");
        }

        public override void Stop()
        {
            Log.Write("Test service stopped");
        }
    }
}
