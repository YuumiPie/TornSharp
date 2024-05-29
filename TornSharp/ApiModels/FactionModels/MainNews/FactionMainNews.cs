using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.MainNews;

public class FactionMainNews : JsonModel, IFactionStatistics
{
    [JsonPropertyName("mainnews")]
    public Dictionary<string, NewsEntry> MainNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.mainnews.ToString();
    }
}