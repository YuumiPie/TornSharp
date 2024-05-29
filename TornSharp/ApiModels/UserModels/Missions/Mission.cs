using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Missions;

public class Mission : JsonModel
{
    [JsonPropertyName("status")]
    public MissionStatus Status { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}