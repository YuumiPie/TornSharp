using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Companies;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SpecialAbility
{
    Cleaner,
    Manager,
    Marketer,
    None,
    Secretary,
    Trainer
}