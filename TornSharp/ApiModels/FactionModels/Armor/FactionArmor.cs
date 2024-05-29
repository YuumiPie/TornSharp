using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Armor;

public class FactionArmor : JsonModel, IFactionStatistics
{
    [JsonPropertyName("armor")]
    public List<Armor> Armor { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.armor.ToString();
    }
}