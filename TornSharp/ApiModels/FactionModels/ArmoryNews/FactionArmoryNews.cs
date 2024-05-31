using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.ArmoryNews;

public class FactionArmoryNews : JsonModel, IFactionStats
{
    [JsonPropertyName("armorynews")]
    public Dictionary<int, NewsEntry> ArmoryNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.armorynews.ToString();
    }
}