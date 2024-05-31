using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Properties;

public class UserProperties : JsonModel, IUserStats
{
    [JsonPropertyName("properties")]
    public Dictionary<int, Property> Properties { get; set; }

    public string GetMethodName()
    {
        return UserMethods.properties.ToString();
    }
}