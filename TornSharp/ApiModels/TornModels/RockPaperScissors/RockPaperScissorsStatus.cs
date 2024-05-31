using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RockPaperScissors;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RockPaperScissorsStatus
{
    [EnumMember(Value = "paper")]
    Paper,
    [EnumMember(Value = "rock")]
    Rock,
    [EnumMember(Value = "scissors")]
    Scissors,
}