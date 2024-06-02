using System.Text.Json;
using System.Text.Json.Serialization;

namespace TornSharp.CustomJsonConverter;

public class UnixDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using JsonDocument jsonDoc = JsonDocument.ParseValue(ref reader);
        string rawTime = jsonDoc.RootElement.GetRawText();
        if (int.TryParse(rawTime, out int unixTime))
        {
            return DateTime.UnixEpoch.AddSeconds(unixTime);
        }
        rawTime = rawTime.Replace("\"", "");
        return DateTime.Parse(rawTime);
    }
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}