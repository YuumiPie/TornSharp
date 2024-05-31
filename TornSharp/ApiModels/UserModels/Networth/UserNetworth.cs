using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Networth;

public class UserNetworth : JsonModel, IUserStats
{
    [JsonPropertyName("networth")]
    public Networth Networth { get; set; }

    public string GetMethodName()
    {
        return UserMethods.networth.ToString();
    }
}