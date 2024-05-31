using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Currency;

public class FactionCurrency : JsonModel, IFactionStats
{
    [JsonPropertyName("faction_id")]
    public int FactionId { get; set; }

    [JsonPropertyName("money")]
    public int Money { get; set; }

    [JsonPropertyName("points")]
    public int Points { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.currency.ToString();
    }
}