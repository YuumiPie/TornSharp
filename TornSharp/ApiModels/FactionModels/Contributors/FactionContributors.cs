using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Contributors;

public class FactionContributors : JsonModel, IFactionStats
{
    [JsonPropertyName("contributors")]
    public Contributors Contributors { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.contributors.ToString();
    }
}