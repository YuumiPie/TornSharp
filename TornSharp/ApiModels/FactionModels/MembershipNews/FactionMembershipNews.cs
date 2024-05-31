using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.MembershipNews;

public class FactionMembershipNews : JsonModel, IFactionStats
{
    [JsonPropertyName("membershipnews")]
    public Dictionary<int, NewsEntry> MembershipNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.membershipnews.ToString();
    }
}