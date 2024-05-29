using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Messages;

public class UserMessages : JsonModel, IUserStatistics
{
    [JsonPropertyName("messages")]
    public Dictionary<string, Message> Messages { get; set; }

    public string GetMethodName()
    {
        return UserMethods.messages.ToString();
    }
}