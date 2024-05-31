using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.AttacksFull;

public class FactionAttacksFull : JsonModel, IFactionStats
{
    [JsonPropertyName("attacks")]
    public Dictionary<int, AttackFull> Attacks { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.attacksfull.ToString();
    }
}