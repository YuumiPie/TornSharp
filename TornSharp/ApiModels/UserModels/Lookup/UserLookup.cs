using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Lookup;

public class UserLookup : JsonModel, IUserStatistics
{
    [JsonPropertyName("selections")]
    public List<string> Selections { get; set; }

    public string GetMethodName()
    {
        return UserMethods.lookup.ToString();
    }
}