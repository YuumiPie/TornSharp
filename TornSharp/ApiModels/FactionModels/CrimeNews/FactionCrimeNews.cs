using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.CrimeNews;

public class FactionCrimeNews : JsonModel, IFactionStats
{
    [JsonPropertyName("crimenews")]
    public Dictionary<long, NewsEntry> CrimeNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.crimenews.ToString();
    }
}