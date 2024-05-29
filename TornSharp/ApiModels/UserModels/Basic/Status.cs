using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Basic;

public class Status : JsonModel
{
    [JsonPropertyName("color")]
    public Color Color { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("state")]
    public StatusState State { get; set; }

    [JsonPropertyName("until")]
    public int Until { get; set; }
}