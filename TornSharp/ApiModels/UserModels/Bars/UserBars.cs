using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Bars;

public class UserBars : JsonModel, IUserStatistics
{
    [JsonPropertyName("chain")]
    public ChainBar Chain { get; set; }

    [JsonPropertyName("energy")]
    public Bar Energy { get; set; }

    [JsonPropertyName("happy")]
    public Bar Happy { get; set; }

    [JsonPropertyName("life")]
    public Bar Life { get; set; }

    [JsonPropertyName("nerve")]
    public Bar Nerve { get; set; }

    [JsonPropertyName("server_time")]
    public int ServerTime { get; set; }

    public string GetMethodName()
    {
        return UserMethods.bars.ToString();
    }
}