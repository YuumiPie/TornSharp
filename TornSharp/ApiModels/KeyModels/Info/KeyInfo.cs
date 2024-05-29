using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.KeyModels.Info;

public class KeyInfo : JsonModel, IKeyStatistics
{
    [JsonPropertyName("access_level")]
    public AccessLevel AccessLevel { get; set; }

    [JsonPropertyName("access_type")]
    public AccessType AccessType { get; set; }

    [JsonPropertyName("selections")]
    public Selections Selections { get; set; }

    public string GetMethodName()
    {
        return KeyMethods.info.ToString();
    }
}