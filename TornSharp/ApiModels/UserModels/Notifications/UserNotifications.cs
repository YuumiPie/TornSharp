using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Notifications;

public class UserNotifications : JsonModel, IUserStats
{
    [JsonPropertyName("notifications")]
    public Notifications Notifications { get; set; }

    public string GetMethodName()
    {
        return UserMethods.notifications.ToString();
    }
}