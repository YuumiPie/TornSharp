using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Networth;

public class UserNetworth : JsonModel, IUserStatistics
{
    [JsonPropertyName("networth")]
    public Networth Networth { get; set; }

    public string GetMethodName()
    {
        return UserMethods.networth.ToString();
    }
}