using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.ChainReport;

public class TornChainReport : JsonModel, ITornStats
{
    [JsonPropertyName("chainreport")]
    public ChainReport ChainReport { get; set; }

    public string GetMethodName()
    {
        return TornMethods.chainreport.ToString();
    }
}