using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Chain;

public class FactionChain : JsonModel, IFactionStats
{
    [JsonPropertyName("chain")]
    public Chain Chain { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.chain.ToString();
    }
}