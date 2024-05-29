using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Basic;

public class UserBasic : JsonModel, IUserStatistics
{
    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; }

    public string GetMethodName()
    {
        return UserMethods.basic.ToString();
    }
}