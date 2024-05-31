using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Hof;

public class UserHof : JsonModel, IUserStats
{
    [JsonPropertyName("hof")]
    public Dictionary<int, HallOfFame> hof { get; set; }

    public string GetMethodName()
    {
        return UserMethods.hof.ToString();
    }
}