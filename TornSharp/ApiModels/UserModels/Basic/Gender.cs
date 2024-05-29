using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Basic;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Gender
{
    Enby,
    Female,
    Male,
}