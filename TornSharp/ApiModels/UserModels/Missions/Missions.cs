using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Missions;

public class Missions
{
    [JsonPropertyName("Duke")]
    public List<Mission> Duke { get; set; }
}