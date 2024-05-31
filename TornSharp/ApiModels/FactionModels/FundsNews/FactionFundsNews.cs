using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.FundsNews;

public class FactionFundsNews : JsonModel, IFactionStats
{
    [JsonPropertyName("fundsnews")]
    public Dictionary<int, NewsEntry> FundsNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.fundsnews.ToString();
    }
}