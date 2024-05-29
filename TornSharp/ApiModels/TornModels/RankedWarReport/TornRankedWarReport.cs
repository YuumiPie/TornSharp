using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RankedWarReport;

public class TornRankedWarReport : JsonModel, ITornStats
{
    [JsonPropertyName("rankedwarreport")]
    public RankedWarReport RankedWarReport { get; set; }

    public string GetMethodName()
    {
        return TornMethods.rankedwarreport.ToString();
    }
}