using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Temporary;

public class FactionTemporary : JsonModel, IFactionStats
{
    [JsonPropertyName("temporary")]
    public List<LoanableArmoryItem> Temporary { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.temporary.ToString();
    }
}