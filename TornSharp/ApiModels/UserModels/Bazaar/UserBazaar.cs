using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Bazaar;

public class UserBazaar : JsonModel, IUserStats
{
    [JsonPropertyName("bazaar")]
    public List<Bazaar> Bazaar { get; set; }

    public string GetMethodName()
    {
        return UserMethods.bazaar.ToString();
    }
}