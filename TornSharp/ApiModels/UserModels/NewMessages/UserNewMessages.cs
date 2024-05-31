using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.NewMessages;

public class UserNewMessages : JsonModel, IUserStats
{
    [JsonPropertyName("messages")]
    public Dictionary<int, Message> Messages { get; set; }

    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    public string GetMethodName()
    {
        return UserMethods.newmessages.ToString();
    }
}