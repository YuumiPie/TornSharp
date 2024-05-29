using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Upgrades;

public class Upgrade : JsonModel
{
    [JsonPropertyName("ability")]
    public string Ability { get; set; }

    [JsonPropertyName("basecost")]
    public int BaseCost { get; set; }

    [JsonPropertyName("branch")]
    public Branch Branch { get; set; }

    [JsonPropertyName("branchmultiplier")]
    public int BranchMultiplier { get; set; }

    [JsonPropertyName("branchorder")]
    public int BranchOrder { get; set; }

    [JsonPropertyName("can_be_unset")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? CanBeUnset { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("unlocked")]
    public string Unlocked { get; set; }
}