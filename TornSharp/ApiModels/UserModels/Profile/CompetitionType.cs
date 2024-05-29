using System.Runtime.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

public enum CompetitionType
{
    [EnumMember(Value = "Dog Tags")]
    DogTags,
    [EnumMember(Value = "Easter Egg Hunt")]
    EasterEggHunt,
    Elimination,
    Halloween,
    [EnumMember(Value = "Mr & Ms Torn")]
    MrAndMsTorn,
    [EnumMember(Value = "Rock, Paper, Scissors")]
    RockPaperScissors,
}