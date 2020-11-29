using BenchmarkDotNet.Running;
using System;
using System.IO;
using System.Text.Json;

namespace ProtoBuf.Serialization.Demo
{
    static class Program
    {
        private const string protoFileName = "tournament.bin";
        private const string jsonFileName = "tournament.json";

        static void Main(string[] args)
        {
            // Run banchmark
            BenchmarkRunner.Run<SerializationBanchmark>();

            // Run size comparsion test
            SizeComparsion();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static void SizeComparsion()
        {
            Console.WriteLine($"Proto file size: \t {SaveProto(protoFileName)}");
            Console.WriteLine($"Json file size: \t {SaveJson(jsonFileName)}");
        }

        private static long SaveProto(string fileName)
        {
            using (var file = File.Create(fileName))
            {
                Serializer.Serialize(file, TournamentHelper.Tournaments);
            }

            return new FileInfo(fileName).Length;
        }

        private static long SaveJson(string fileName)
        {
            using (var file = File.CreateText(fileName))
            {
                file.Write(JsonSerializer.Serialize(TournamentHelper.Tournaments));
            }

            return new FileInfo(fileName).Length;
        }
    }
}
