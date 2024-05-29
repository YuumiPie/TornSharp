using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Hof;

public class UserHof : JsonModel, IUserStatistics
{
    [JsonPropertyName("hof")]
    public Dictionary<string, HallOfFame> hof { get; set; }

    public string GetMethodName()
    {
        return UserMethods.hof.ToString();
    }
}