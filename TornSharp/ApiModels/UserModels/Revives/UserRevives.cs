using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Revives;

public class UserRevives : JsonModel, IUserStatistics
{
    [JsonPropertyName("revives")]
    public Dictionary<string, Revive> Revives { get; set; }

    public string GetMethodName()
    {
        return UserMethods.revives.ToString();
    }
}