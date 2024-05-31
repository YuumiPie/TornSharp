using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Crimes;

public class FactionCrimes : JsonModel, IFactionStats
{
    [JsonPropertyName("crimes")]
    public Dictionary<long, Crime> Crimes { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.crimes.ToString();
    }
}