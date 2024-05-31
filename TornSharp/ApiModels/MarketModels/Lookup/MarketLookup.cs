using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.MarketModels.Lookup;

public class MarketLookup : JsonModel, IMarketStats
{
    [JsonPropertyName("selections")]
    public List<string> Selections { get; set; }

    public string GetMethodName()
    {
        return MarketMethods.lookup.ToString();
    }
}