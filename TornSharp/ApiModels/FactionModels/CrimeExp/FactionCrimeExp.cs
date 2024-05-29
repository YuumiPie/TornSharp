using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.CrimeExp;

public class FactionCrimeExp : JsonModel, IFactionStatistics
{
    [JsonPropertyName("crimeexp")]
    public List<int> CrimeExp { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.crimeexp.ToString();
    }
}