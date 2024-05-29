using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.ChainReport;

public class FactionChainReport : JsonModel, IFactionStatistics
{
    [JsonPropertyName("chainreport")]
    public ChainReport ChainReport { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.chainreport.ToString();
    }
}