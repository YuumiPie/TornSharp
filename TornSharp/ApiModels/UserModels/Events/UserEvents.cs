using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Events;

public class UserEvents : JsonModel, IUserStats
{
    [JsonPropertyName("events")]
    public Dictionary<string, Event> Events { get; set; }

    public string GetMethodName()
    {
        return UserMethods.events.ToString();
    }
}