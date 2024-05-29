using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Crimes;

public class FactionCrimes : JsonModel, IFactionStatistics
{
    [JsonPropertyName("crimes")]
    public Dictionary<long, Crime> Crimes { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.crimes.ToString();
    }
}