using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.ArmoryNews;

public class FactionArmoryNews : JsonModel, IFactionStatistics
{
    [JsonPropertyName("armorynews")]
    public Dictionary<string, NewsEntry> ArmoryNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.armorynews.ToString();
    }
}