using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.MainNews;

public class FactionMainNews : JsonModel, IFactionStats
{
    [JsonPropertyName("mainnews")]
    public Dictionary<int, NewsEntry> MainNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.mainnews.ToString();
    }
}