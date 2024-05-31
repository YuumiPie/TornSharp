using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Reports;

public class ReportData : JsonModel
{
    [JsonPropertyName("bounties")]
    public List<string>? Bounties { get; set; }

    [JsonPropertyName("company_history")]
    public List<Reference>? CompanyHistory { get; set; }

    [JsonPropertyName("defense")]
    public string? Defence { get; set; }

    [JsonPropertyName("dexterity")]
    public string? Dexterity { get; set; }

    [JsonPropertyName("enemylist")]
    public List<FriendOrFoeUser>? EnemyList { get; set; }

    [JsonPropertyName("faction_history")]
    public List<Reference>? FactionHistory { get; set; }

    [JsonPropertyName("friendlist")]
    public List<FriendOrFoeUser>? FriendList { get; set; }

    [JsonPropertyName("invested_amount")]
    public int? InvestedAmount { get; set; }
    
    [JsonPropertyName("invested_completion")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? InvestedCompletion { get; set; }

    [JsonPropertyName("money")]
    public int? Money { get; set; }

    [JsonPropertyName("otherlist")]
    public List<Warrant>? OtherList { get; set; }

    [JsonPropertyName("speed")]
    public int? Speed { get; set; }

    [JsonPropertyName("strength")]
    public int? Strength { get; set; }

    [JsonPropertyName("toplist")]
    public List<Warrant>? Toplist { get; set; }

    [JsonPropertyName("total_battlestats")]
    public int? TotalBattlestats { get; set; }

    [JsonPropertyName("truelevel")]
    public int? TrueLevel { get; set; }
}