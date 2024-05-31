using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Basic;

public class FactionBasic : JsonModel, IFactionStats
{
    [JsonPropertyName("age")]
    public int Age { get; set; }

    [JsonPropertyName("best_chain")]
    public int BestChain { get; set; }

    [JsonPropertyName("capacity")]
    public int Capacity { get; set; }

    [JsonPropertyName("co-leader")]
    public int Coleader { get; set; }

    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("leader")]
    public int Leader { get; set; }

    [JsonPropertyName("members")]
    public Dictionary<long, Member> Members { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("peace")]
    [JsonConverter(typeof(DictionaryUnixDateTimeConverter))]
    public Dictionary<int, DateTime> Peace { get; set; }

    [JsonPropertyName("raid_wars")]
    public List<Raid> RaidWars { get; set; }

    [JsonPropertyName("rank")]
    public Ranking Rank { get; set; }

    [JsonPropertyName("ranked_wars")]
    public RankedWar RankedWars { get; set; }

    [JsonPropertyName("respect")]
    public int Respect { get; set; }

    [JsonPropertyName("tag")]
    public string Tag { get; set; }

    [JsonPropertyName("tag_image")]
    public string TagImage { get; set; }

    [JsonPropertyName("territory_wars")]
    public List<TerritoryWar> TerritoryWars { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.basic.ToString();
    }
}