using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.AttackNews;

public class FactionAttackNews : JsonModel, IFactionStatistics
{
    [JsonPropertyName("attacknews")]
    public Dictionary<string, NewsEntry> AttackNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.attacknews.ToString();
    }
}