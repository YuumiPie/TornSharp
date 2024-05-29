using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.WeaponExp;

public class UserWeaponExp : JsonModel, IUserStatistics
{
    [JsonPropertyName("weaponexp")]
    public List<WeaponExperience> WeaponExp { get; set; }

    public string GetMethodName()
    {
        return UserMethods.weaponexp.ToString();
    }
}