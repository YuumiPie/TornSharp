using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Chains;

public class FactionChains : JsonModel, IFactionStats
{
    [JsonPropertyName("chains")]
    public Dictionary<long, Chain> Chains { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.chains.ToString();
    }
}