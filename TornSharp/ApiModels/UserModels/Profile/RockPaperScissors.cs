using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RockPaperScissors
{
    [EnumMember(Value = "paper")]
    Paper,
    [EnumMember(Value = "rock")]
    Rock,
    [EnumMember(Value = "scissors")]
    Scissors,
}