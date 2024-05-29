using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Weapons;

public class FactionWeapons : JsonModel, IFactionStatistics
{
    [JsonPropertyName("weapons")]
    public List<LoanableArmoryItem> Weapons { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.weapons.ToString();
    }
}