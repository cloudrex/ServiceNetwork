using ServiceNetwork.Manager;
using ServiceNetwork.Structures.Network;
using System;

namespace ServiceNetwork.Structures
{
    public abstract class Service
    {
        public abstract ServiceMeta Meta { get; }

        // TODO: Dynamic would mean that we'd have to re-parse using JsonConvert
        public event EventHandler<NetPacket<dynamic>> OnMessage;

        public abstract void Start();

        public abstract void Stop();

        protected readonly NetworkHub hub;
    }
}
