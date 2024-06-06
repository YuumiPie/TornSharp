using System.Text.Json;
using System.Text.Json.Serialization;

namespace TornSharp.CustomJsonConverter;

public class DictionaryUnixDateTimeConverter : JsonConverter<Dictionary<int, DateTime>>
{
    public override Dictionary<int, DateTime> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Dictionary<int, DateTime> dictionary = [];

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return dictionary;
            }
            // Get the key.
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            int propertyName = int.Parse(reader.GetString());

            reader.Read();
            DateTime dateTime = DateTime.UnixEpoch.AddSeconds(reader.GetInt32());

            // Add to dictionary.
            dictionary.Add(propertyName, dateTime);
        }

        throw new JsonException();
    }
    public override void Write(Utf8JsonWriter writer, Dictionary<int, DateTime> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}