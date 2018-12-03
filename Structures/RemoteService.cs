using ServiceNetwork.Manager;
using ServiceNetwork.Structures.Network;
using System.Threading.Tasks;

namespace ServiceNetwork.Structures
{
    public class RemoteService
    {
        public readonly ServiceMeta Meta;

        private readonly NetworkHub hub;

        public RemoteService(NetworkHub manager, ServiceMeta meta)
        {
            this.hub = manager;
            this.Meta = meta;
        }

        public Task<bool> Dispatch<PayloadType>(NetPacket<PayloadType> packet)
        {
            return this.hub.Dispatch(packet, this.Meta.Id);
        }
    }
}
