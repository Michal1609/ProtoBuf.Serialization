using System;

namespace ProtoBuf.Serialization.Demo.Models
{
    [ProtoContract]
    public class Tournament
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public string Description { get; set; }

        [ProtoMember(4)]
        public DateTime MatchDate { get; set; }

        [ProtoMember(5)]
        public int Players { get; set; }
    }

}
