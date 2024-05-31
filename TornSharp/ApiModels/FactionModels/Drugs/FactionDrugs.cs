using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Drugs;

public class FactionDrugs : JsonModel, IFactionStats
{
    [JsonPropertyName("drugs")]
    public List<ArmoryItem> Drugs { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.drugs.ToString();
    }
}