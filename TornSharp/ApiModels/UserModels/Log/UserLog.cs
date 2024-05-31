using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Log;

public class UserLog : JsonModel, IUserStats
{
    [JsonPropertyName("log")]
    public Dictionary<string, Log> Logs { get; set; }

    public string GetMethodName()
    {
        return UserMethods.log.ToString();
    }
}