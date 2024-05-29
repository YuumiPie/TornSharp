using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.Timestamp;

public class UserTimestamp : JsonModel, IUserStatistics
{
    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    public string GetMethodName()
    {
        return UserMethods.timestamp.ToString();
    }
}