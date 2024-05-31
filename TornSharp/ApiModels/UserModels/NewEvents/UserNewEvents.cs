using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.NewEvents;

public class UserNewEvents : JsonModel, IUserStats
{
    [JsonPropertyName("events")]
    public Dictionary<string, Event> Notifications { get; set; }
    
    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }   

    public string GetMethodName()
    {
        return UserMethods.newevents.ToString();
    }
}