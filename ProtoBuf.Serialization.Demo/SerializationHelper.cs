using System.IO;

namespace ProtoBuf.Serialization.Demo
{
    public static class SerializationHelper
    {
        public static Stream ProtoBufSerialize<T>(T data) where T : class
        {
            var stream = new MemoryStream();
            Serializer.Serialize(stream, data);
            return stream;
        }
    }
}
