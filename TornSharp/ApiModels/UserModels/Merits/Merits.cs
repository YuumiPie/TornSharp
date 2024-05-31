using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Merits;

public class Merits : JsonModel
{
    [JsonPropertyName("Addiction Mitigation")]
    public int AddictionMitigation { get; set; }

    [JsonPropertyName("Awareness")]
    public int Awareness { get; set; }

    [JsonPropertyName("Bank Interest")]
    public int BankInterest { get; set; }

    [JsonPropertyName("Brawn")]
    public int Brawn { get; set; }

    [JsonPropertyName("Club Mastery")]
    public int ClubMastery { get; set; }

    [JsonPropertyName("Crime XP")]
    public int CrimeXp { get; set; }

    [JsonPropertyName("Critical Hit Rate")]
    public int CriticalHitRate { get; set; }

    [JsonPropertyName("Education Length")]
    public int EducationLength { get; set; }

    [JsonPropertyName("Employee Effectiveness")]
    public int EmployeeEffectiveness { get; set; }

    [JsonPropertyName("Evasion")]
    public int Evasion { get; set; }

    [JsonPropertyName("Heavy Artillery Mastery")]
    public int HeavyArtilleryMastery { get; set; }

    [JsonPropertyName("Hospitalizing")]
    public int Hospitalizing { get; set; }

    [JsonPropertyName("Life Points")]
    public int LifePoints { get; set; }

    [JsonPropertyName("Machine Gun Mastery")]
    public int MachineGunMastery { get; set; }

    [JsonPropertyName("Masterful Looting")]
    public int MasterfulLooting { get; set; }

    [JsonPropertyName("Mechanical Mastery")]
    public int MechanicalMastery { get; set; }

    [JsonPropertyName("Nerve Bar")]
    public int NerveBar { get; set; }

    [JsonPropertyName("Piercing Mastery")]
    public int PiercingMastery { get; set; }

    [JsonPropertyName("Pistol Mastery")]
    public int PistolMastery { get; set; }

    [JsonPropertyName("Protection")]
    public int Protection { get; set; }

    [JsonPropertyName("Rifle Mastery")]
    public int RifleMastery { get; set; }

    [JsonPropertyName("Sharpness")]
    public int Sharpness { get; set; }

    [JsonPropertyName("Shotgun Mastery")]
    public int ShotgunMastery { get; set; }

    [JsonPropertyName("Slashing Mastery")]
    public int SlashingMastery { get; set; }

    [JsonPropertyName("SMG Mastery")]
    public int SmgMastery { get; set; }

    [JsonPropertyName("Stealth")]
    public int Stealth { get; set; }

    [JsonPropertyName("Temporary Mastery")]
    public int TemporaryMastery { get; set; }
}