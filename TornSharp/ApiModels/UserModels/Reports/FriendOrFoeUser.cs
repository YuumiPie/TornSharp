using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Reports;

public class FriendOrFoeUser : JsonModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}