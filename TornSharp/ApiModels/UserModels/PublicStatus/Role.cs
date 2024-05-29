using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.PublicStatus;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Role
{
    Admin,
    Civilian,
    Committee,
    Helper,
    Moderator,
    [EnumMember(Value = "NPC")]
    Npc,
    Officer,
    Reporter,
    [EnumMember(Value = "Wiki Contributor")]
    WikiContributor,
    [EnumMember(Value = "Wiki Editor")]
    WikiEditor,
}