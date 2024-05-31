using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Equipment;

public class UserEquipment : JsonModel, IUserStats
{
    [JsonPropertyName("equipment")]
    public List<EquippedItems> Equipment { get; set; }

    public string GetMethodName()
    {
        return UserMethods.equipment.ToString();
    }
}