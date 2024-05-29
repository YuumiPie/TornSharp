using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Attacks;

public class FactionAttacks : JsonModel, IFactionStatistics
{
    [JsonPropertyName("attacks")]
    public Dictionary<string, Attack> Attacks { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.attacks.ToString();
    }
}