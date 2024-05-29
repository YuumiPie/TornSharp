using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.NewEvents;

public class UserNewEvents : JsonModel, IUserStatistics
{
    [JsonPropertyName("events")]
    public Dictionary<string, Event> Notifications { get; set; }

    public string GetMethodName()
    {
        return UserMethods.newevents.ToString();
    }
}