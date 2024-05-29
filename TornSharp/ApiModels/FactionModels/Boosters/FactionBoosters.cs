using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Boosters;

public class FactionBoosters : JsonModel, IFactionStatistics
{
    [JsonPropertyName("boosters")]
    public List<ArmoryItem> Boosters { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.boosters.ToString();
    }
}