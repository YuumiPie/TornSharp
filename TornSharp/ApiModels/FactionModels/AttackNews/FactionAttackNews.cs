using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.AttackNews;

public class FactionAttackNews : JsonModel, IFactionStats
{
    [JsonPropertyName("attacknews")]
    public Dictionary<int, NewsEntry> AttackNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.attacknews.ToString();
    }
}