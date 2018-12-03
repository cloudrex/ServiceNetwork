using Newtonsoft.Json;

namespace ServiceNetwork.Structures.Network
{
    public struct NetPacket<PayloadType>
    {
        [JsonProperty("type")]
        public NetPacketType Type;

        [JsonProperty("payload")]
        public PayloadType Payload { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
