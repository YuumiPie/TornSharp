using System.Text.Json;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels;

public class JsonModel
{
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? ExtensionData { get; set; } = null;
}