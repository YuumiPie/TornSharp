using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.NewEvents;

public class UserNewEvents : JsonModel, IUserStats
{
    [JsonPropertyName("events")]
    public Dictionary<int, Event> Notifications { get; set; }

    public string GetMethodName()
    {
        return UserMethods.newevents.ToString();
    }
}