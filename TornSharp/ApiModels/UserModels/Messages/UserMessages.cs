using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Messages;

public class UserMessages : JsonModel, IUserStats
{
    [JsonPropertyName("messages")]
    public Dictionary<int, Message> Messages { get; set; }

    public string GetMethodName()
    {
        return UserMethods.messages.ToString();
    }
}