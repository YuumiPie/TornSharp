using System.Text.Json;
using System.Text.Json.Serialization;

namespace TornSharp.CustomJsonConverter;

public class NumberToStringConverter : JsonConverter<string>
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert == typeof(string);
    }
    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.TryGetInt64(out long l) ? l.ToString() : reader.GetDouble().ToString();
        }
        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }
        using (JsonDocument document = JsonDocument.ParseValue(ref reader))
        {
            return document.RootElement.Clone().ToString();
        }
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}