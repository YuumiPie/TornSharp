using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Revives;

public class UserRevives : JsonModel, IUserStats
{
    [JsonPropertyName("revives")]
    public Dictionary<int, Revive> Revives { get; set; }

    public string GetMethodName()
    {
        return UserMethods.revives.ToString();
    }
}