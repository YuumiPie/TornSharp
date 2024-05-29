using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Applications;

public class FactionApplications : JsonModel, IFactionStatistics
{
    [JsonPropertyName("applications")]
    public Dictionary<string, Application> Applications { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.applications.ToString();
    }
}