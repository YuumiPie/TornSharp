using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Medical;

public class FactionMedical : JsonModel, IFactionStats
{
    [JsonPropertyName("medical")]
    public List<ArmoryItem> Medical { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.medical.ToString();
    }
}