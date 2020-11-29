using BenchmarkDotNet.Attributes;
using ProtoBuf.Serialization.Demo.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace ProtoBuf.Serialization.Demo
{
    [MemoryDiagnoser]
    public class SerializationBanchmark
    {
        [Benchmark]
        public List<Tournament> JsonSerialize() =>
             JsonSerializer.Deserialize<List<Tournament>>(JsonSerializer.Serialize(TournamentHelper.Tournaments));


        [Benchmark]
        public List<Tournament> ProtoSerialize() =>
            Serializer.Deserialize<List<Tournament>>(SerializationHelper.ProtoBufSerialize(TournamentHelper.Tournaments));
    }
}
