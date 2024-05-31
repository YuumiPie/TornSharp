using System.Text.Json;
using System.Text.Json.Serialization;
using TornSharp.ApiModels.FactionModels;

namespace TornSharp.JsonDeserializerOptions;

public class BlankStringToNumberConverter : JsonConverter<int>
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert == typeof(int);
    }
    
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using JsonDocument jsonDoc = JsonDocument.ParseValue(ref reader);
        string rawInt = jsonDoc.RootElement.GetRawText();
        if (rawInt.Equals("\"\""))
        {
            return 0;
        }
        return int.Parse(rawInt);
    }
    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}