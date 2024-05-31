using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Applications;

public class FactionApplications : JsonModel, IFactionStats
{
    [JsonPropertyName("applications")]
    public Dictionary<int, Application> Applications { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.applications.ToString();
    }
}