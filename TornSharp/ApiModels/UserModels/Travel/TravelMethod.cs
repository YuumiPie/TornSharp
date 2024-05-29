using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Travel;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TravelMethod
{
    Airstrip,
    Business,
    Private,
    Standard
}