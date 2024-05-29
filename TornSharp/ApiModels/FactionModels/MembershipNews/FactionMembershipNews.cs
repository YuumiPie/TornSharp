using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.MembershipNews;

public class FactionMembershipNews : JsonModel, IFactionStatistics
{
    [JsonPropertyName("membershipnews")]
    public Dictionary<string, NewsEntry> MembershipNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.membershipnews.ToString();
    }
}