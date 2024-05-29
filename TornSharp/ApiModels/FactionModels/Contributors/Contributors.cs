namespace TornSharp.ApiModels.FactionModels.Contributors;

public class Contributors : JsonModel
{
    public Dictionary<long, List<MemberContributor>> FactionStat { get; set; }
    public List<KeyValuePair<long?, MemberContributor>> UserStat { get; set; }
}