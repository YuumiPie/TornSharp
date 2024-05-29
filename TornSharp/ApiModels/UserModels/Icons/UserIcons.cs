using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Icons;

public class UserIcons : JsonModel, IUserStatistics
{
    [JsonPropertyName("icons")]
    public Dictionary<string, string> Icons { get; set; }

    public string GetMethodName()
    {
        return UserMethods.icons.ToString();
    }
}