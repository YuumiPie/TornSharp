using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Competition;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CompetitionType
{
    [EnumMember(Value = "Dog Tags")]
    DogTags,
    [EnumMember(Value = "Easter Egg Hunt")]
    EasterEggHunt,
    Elimination,
    Halloween,
    [EnumMember(Value = "Mr & Ms Torn")]
    MrAndMsTorn
}