using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Ammo;

public class UserAmmo : JsonModel, IUserStats
{
    [JsonPropertyName("ammo")]
    public List<Ammo> Ammo { get; set; }

    public string GetMethodName()
    {
        return UserMethods.ammo.ToString();
    }
}