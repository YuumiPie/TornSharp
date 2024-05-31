using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TornSharp.JsonDeserializerOptions;

public class BracketEmptyArrayConverter : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(List<>);
    }
    
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        Type[] typeArguments = typeToConvert.GetGenericArguments();
        Type listType = typeArguments[0];

        JsonConverter converter = (JsonConverter)Activator.CreateInstance(
            typeof(BracketEmptyArrayConverterInner<>).MakeGenericType(
                [listType]),
            BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: [options],
            culture: null)!;

        return converter;
    }

    private class BracketEmptyArrayConverterInner<TValue> : JsonConverter<List<TValue>>
    {
        public BracketEmptyArrayConverterInner(JsonSerializerOptions options)
        {
        }
        
        public override List<TValue> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument jsonDoc = JsonDocument.ParseValue(ref reader);
            string rawText = jsonDoc.RootElement.GetRawText();
            if (rawText.Equals("{}"))
            {
                return [];
            }
            return jsonDoc.Deserialize<List<TValue>>()!;
        }

        public override void Write(Utf8JsonWriter writer, List<TValue> list, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}