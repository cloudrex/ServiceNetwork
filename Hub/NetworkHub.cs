using ServiceNetwork.Structures;
using ServiceNetwork.Structures.Network;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceNetwork.Manager
{
    public abstract class NetworkHub
    {
        private readonly Dictionary<string, RemoteService> services;

        public NetworkHub()
        {
            this.services = new Dictionary<string, RemoteService>();
        }

        public bool ContainsService(string id)
        {
            return this.services.ContainsKey(id);
        }

        public virtual void Broadcast<PayloadType>(NetPacket<PayloadType> packet)
        {
            // TODO
        }

        public virtual async Task<bool> Dispatch<PayloadType>(NetPacket<PayloadType> packet, string destination)
        {
            // TODO

            return false;
        }
    }
}
