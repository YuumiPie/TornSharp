using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.AttacksFull;

public class FactionAttacksFull : JsonModel, IFactionStatistics
{
    [JsonPropertyName("attacks")]
    public Dictionary<string, AttackFull> Attacks { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.attacksfull.ToString();
    }
}