using System;
using System.IO;
using System.Text.Json;

namespace ObjectSerializer
{
    public static class WriteObjectToJson
    {
        public static void SerializeToJsonFormat<T>(T objGraph, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };
            File.WriteAllText(fileName, JsonSerializer.Serialize(objGraph, options));
        }

    }
}
