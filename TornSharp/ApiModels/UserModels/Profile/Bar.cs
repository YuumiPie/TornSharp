using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

public class Bar : JsonModel
{
    [JsonPropertyName("current")]
    public int Current { get; set; }

    [JsonPropertyName("fulltime")]
    public int FullTime { get; set; }

    [JsonPropertyName("increment")]
    public int Increment { get; set; }

    [JsonPropertyName("interval")]
    public int Interval { get; set; }

    [JsonPropertyName("maximum")]
    public int Maximum { get; set; }

    [JsonPropertyName("ticktime")]
    public int Ticktime { get; set; }
}