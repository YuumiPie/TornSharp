using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Lookup;

public class UserLookup : JsonModel, IUserStats
{
    [JsonPropertyName("selections")]
    public List<string> Selections { get; set; }

    public string GetMethodName()
    {
        return UserMethods.lookup.ToString();
    }
}