using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Companies;

public class Position : JsonModel
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("end_gain")]
    public int EndGain { get; set; }

    [JsonPropertyName("end_required")]
    public int EndRequired { get; set; }

    [JsonPropertyName("int_gain")]
    public int IntGain { get; set; }

    [JsonPropertyName("int_required")]
    public int IntRequired { get; set; }

    [JsonPropertyName("man_gain")]
    public int ManGain { get; set; }

    [JsonPropertyName("man_required")]
    public int ManRequired { get; set; }

    [JsonPropertyName("special_ability")]
    public SpecialAbility SpecialAbility { get; set; }
}