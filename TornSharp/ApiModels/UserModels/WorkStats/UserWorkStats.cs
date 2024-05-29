using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.WorkStats;

public class UserWorkStats : JsonModel, IUserStatistics
{
    [JsonPropertyName("endurance")]
    public int Endurance { get; set; }

    [JsonPropertyName("intelligence")]
    public int Intelligence { get; set; }

    [JsonPropertyName("manual_labor")]
    public int ManualLabor { get; set; }

    public string GetMethodName()
    {
        return UserMethods.workstats.ToString();
    }
}