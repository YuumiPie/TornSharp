using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RaidReport;

public class TornRaidReport : JsonModel, ITornStats
{
    [JsonPropertyName("raidreport")]
    public RaidReport RaidReport { get; set; }

    public string GetMethodName()
    {
        return TornMethods.raidreport.ToString();
    }
}