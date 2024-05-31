using System.Text.Json;
using System.Text.Json.Serialization;

namespace TornSharp.CustomJsonConverter;

public class BoolConverter : JsonConverter<bool>
{
    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) =>
        writer.WriteBooleanValue(value);

    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType switch
        {
            JsonTokenType.True => true,
            JsonTokenType.False => false,
            JsonTokenType.String => bool.TryParse(reader.GetString(), out bool b) ? b : throw new JsonException(),
            JsonTokenType.Number => reader.TryGetInt64(out long l) ? Convert.ToBoolean(l) : reader.TryGetDouble(out double d) ? Convert.ToBoolean(d) : false,
            _ => throw new JsonException(),
        };
}