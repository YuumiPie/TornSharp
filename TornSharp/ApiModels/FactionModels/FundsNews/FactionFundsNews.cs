using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.FundsNews;

public class FactionFundsNews : JsonModel, IFactionStatistics
{
    [JsonPropertyName("fundsnews")]
    public Dictionary<string, NewsEntry> FundsNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.fundsnews.ToString();
    }
}