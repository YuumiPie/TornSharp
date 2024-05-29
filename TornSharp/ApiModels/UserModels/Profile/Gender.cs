using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Gender
{
    Enby,
    Female,
    Male,
}