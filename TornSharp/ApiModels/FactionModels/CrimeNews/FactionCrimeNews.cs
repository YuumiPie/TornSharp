using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.CrimeNews;

public class FactionCrimeNews : JsonModel, IFactionStatistics
{
    [JsonPropertyName("crimenews")]
    public Dictionary<long, NewsEntry> CrimeNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.crimenews.ToString();
    }
}