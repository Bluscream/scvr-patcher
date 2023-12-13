﻿using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SCVRPatcher {

    internal static class Extensions {

        public static string ReadAllText(this FileInfo file) => File.ReadAllText(file.FullName);
        public static IEnumerable<string> ReadAllLines(this FileInfo file) => File.ReadAllLines(file.FullName);

        public static JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions() {
            WriteIndented = true,
            Converters = { new IPAddressConverter() }
        };

        public static string ToJson(this object obj) { // , bool indented = false
            return JsonSerializer.Serialize(obj, JsonSerializerOptions);
        }
    }

    public class IPAddressConverter : JsonConverter<IPAddress> {

        public override IPAddress Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            return IPAddress.Parse(reader.GetString() ?? string.Empty);
        }

        public override void Write(Utf8JsonWriter writer, IPAddress value, JsonSerializerOptions options) {
            writer.WriteStringValue(value.ToString());
        }
    }
}