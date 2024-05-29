using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.KeyModels.Info;

public class Selections : JsonModel
{
    [JsonPropertyName("company")]
    public List<string> Company { get; set; }

    [JsonPropertyName("faction")]
    public List<string> Faction { get; set; }

    [JsonPropertyName("key")]
    public List<string> Key { get; set; }

    [JsonPropertyName("market")]
    public List<string> Market { get; set; }

    [JsonPropertyName("property")]
    public List<string> Property { get; set; }

    [JsonPropertyName("torn")]
    public List<string> Torn { get; set; }

    [JsonPropertyName("user")]
    public List<string> User { get; set; }
}