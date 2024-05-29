using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Positions;

public class Position : JsonModel
{
    [JsonPropertyName("canAccessFactionApi")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanAccessFactionApi { get; set; }

    [JsonPropertyName("canAdjustMemberBalance")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanAdjustMemberBalance { get; set; }

    [JsonPropertyName("canChangeAnnouncement")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanChangeAnnouncement { get; set; }

    [JsonPropertyName("canChangeDescription")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanChangeDescription { get; set; }

    [JsonPropertyName("canGiveItem")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanGiveItem { get; set; }

    [JsonPropertyName("canGiveMoney")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanGiveMoney { get; set; }

    [JsonPropertyName("canGivePoints")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanGivePoints { get; set; }

    [JsonPropertyName("canKickMembers")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanKickMembers { get; set; }

    [JsonPropertyName("canLoanTemporaryItem")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanLoanTemporaryItem { get; set; }

    [JsonPropertyName("canLoanWeaponAndArmory")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanLoanWeaponAndArmory { get; set; }

    [JsonPropertyName("canManageApplications")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanManageApplications { get; set; }

    [JsonPropertyName("canManageForum")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanManageForum { get; set; }

    [JsonPropertyName("canManageUpgrades")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanManageUpgrades { get; set; }

    [JsonPropertyName("canManageWars")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanManageWars { get; set; }

    [JsonPropertyName("canPlanAndInitiateOrganisedCrime")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanPlanAndInitiateOrganisedCrime { get; set; }

    [JsonPropertyName("canRetrieveLoanedArmory")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanRetrieveLoanedArmory { get; set; }

    [JsonPropertyName("canSendNewsletter")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanSendNewsletter { get; set; }

    [JsonPropertyName("canUseBoosterItem")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanUseBoosterItem { get; set; }

    [JsonPropertyName("canUseDrugItem")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanUseDrugItem { get; set; }

    [JsonPropertyName("canUseEnergyRefill")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanUseEnergyRefill { get; set; }

    [JsonPropertyName("canUseMedicalItem")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanUseMedicalItem { get; set; }

    [JsonPropertyName("canUseNerveRefill")]
    [JsonConverter(typeof(BoolConverter))]
    public bool CanUseNerveRefill { get; set; }

    [JsonPropertyName("default")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Default { get; set; }
}