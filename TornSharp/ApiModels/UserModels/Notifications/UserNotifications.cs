using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Notifications;

public class UserNotifications : JsonModel, IUserStatistics
{
    [JsonPropertyName("notifications")]
    public Notifications Notifications { get; set; }

    public string GetMethodName()
    {
        return UserMethods.notifications.ToString();
    }
}