using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Attacks;

public class FactionAttacks : JsonModel, IFactionStats
{
    [JsonPropertyName("attacks")]
    public Dictionary<int, Attack> Attacks { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.attacks.ToString();
    }
}