using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Contributors;

public class MemberContributor : JsonModel
{
    [JsonPropertyName("contributed")]
    public int Contributed { get; set; }

    [JsonPropertyName("in_faction")]
    [JsonConverter(typeof(BoolConverter))]
    public bool InFaction { get; set; }
}