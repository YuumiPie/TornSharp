using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Properties;

public class Staff : JsonModel
{
    [JsonPropertyName("butler")]
    public int Butler { get; set; }

    [JsonPropertyName("doctor")]
    public int Doctor { get; set; }

    [JsonPropertyName("guard")]
    public int Guard { get; set; }

    [JsonPropertyName("maid")]
    public int Maid { get; set; }

    [JsonPropertyName("pilot")]
    public int Pilot { get; set; }
}