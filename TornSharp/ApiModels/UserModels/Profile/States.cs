using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.Profile;

public class States : JsonModel
{
    [JsonPropertyName("hospital_timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime HospitalTimestamp { get; set; }

    [JsonPropertyName("jail_timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime JailTimestamp { get; set; }
}