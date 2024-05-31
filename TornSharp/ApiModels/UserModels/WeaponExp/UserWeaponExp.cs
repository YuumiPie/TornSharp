using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.WeaponExp;

public class UserWeaponExp : JsonModel, IUserStats
{
    [JsonPropertyName("weaponexp")]
    public List<WeaponExperience> WeaponExp { get; set; }

    public string GetMethodName()
    {
        return UserMethods.weaponexp.ToString();
    }
}