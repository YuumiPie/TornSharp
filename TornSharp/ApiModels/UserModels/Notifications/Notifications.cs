using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Notifications;

public class Notifications : JsonModel
{
    [JsonPropertyName("awards")]
    public int Awards { get; set; }

    [JsonPropertyName("competition")]
    public int Competition { get; set; }

    [JsonPropertyName("events")]
    public int Events { get; set; }

    [JsonPropertyName("messages")]
    public int Messages { get; set; }
}