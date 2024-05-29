using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Stats;

public class Stats : JsonModel
{
    [JsonPropertyName("alcoholused")]
    public int AlcoholUsed { get; set; }

    [JsonPropertyName("attacksdamage")]
    public int AttacksDamage { get; set; }

    [JsonPropertyName("attacksdamagehits")]
    public int AttacksDamageHits { get; set; }

    [JsonPropertyName("attacksdamaging")]
    public int AttacksDamaging { get; set; }

    [JsonPropertyName("attackshosp")]
    public int AttacksHosp { get; set; }

    [JsonPropertyName("attacksleave")]
    public int AttacksLeave { get; set; }

    [JsonPropertyName("attackslost")]
    public int AttacksLost { get; set; }

    [JsonPropertyName("attacksmug")]
    public int AttacksMug { get; set; }

    [JsonPropertyName("attacksrunaway")]
    public int AttacksRunaway { get; set; }

    [JsonPropertyName("attackswon")]
    public int AttacksWon { get; set; }

    [JsonPropertyName("bestchain")]
    public int BestChain { get; set; }

    [JsonPropertyName("busts")]
    public int Busts { get; set; }

    [JsonPropertyName("candyused")]
    public int CandyUsed { get; set; }

    [JsonPropertyName("caymaninterest")]
    public int CaymanInterest { get; set; }

    [JsonPropertyName("criminaloffences")]
    public int CriminalOffences { get; set; }

    [JsonPropertyName("drugoverdoses")]
    public int DrugOverdoses { get; set; }

    [JsonPropertyName("drugsused")]
    public int DrugsUsed { get; set; }

    [JsonPropertyName("energydrinkused")]
    public int EnergyDrinkUsed { get; set; }

    [JsonPropertyName("gymdefense")]
    public int GymDefense { get; set; }

    [JsonPropertyName("gymdexterity")]
    public int GymDexterity { get; set; }

    [JsonPropertyName("gymspeed")]
    public int GymSpeed { get; set; }

    [JsonPropertyName("gymstrength")]
    public int GymStrength { get; set; }

    [JsonPropertyName("gymtrains")]
    public int GymTrains { get; set; }

    [JsonPropertyName("highestterritories")]
    public int HighestTerritories { get; set; }

    [JsonPropertyName("hosps")]
    public int Hosps { get; set; }

    [JsonPropertyName("hosptimegiven")]
    public int HospTimeGiven { get; set; }

    [JsonPropertyName("hosptimereceived")]
    public int HospTimeReceived { get; set; }

    [JsonPropertyName("hunting")]
    public int Hunting { get; set; }

    [JsonPropertyName("jails")]
    public int Jails { get; set; }

    [JsonPropertyName("medicalcooldownused")]
    public int MedicalCooldownUsed { get; set; }

    [JsonPropertyName("medicalitemrecovery")]
    public int MedicalItemRecovery { get; set; }

    [JsonPropertyName("medicalitemsused")]
    public int MedicalItemsUsed { get; set; }

    [JsonPropertyName("organisedcrimefail")]
    public int OrganisedCrimeFail { get; set; }

    [JsonPropertyName("organisedcrimemoney")]
    public int OrganisedCrimeMoney { get; set; }

    [JsonPropertyName("organisedcrimerespect")]
    public int OrganisedCrimeRespect { get; set; }

    [JsonPropertyName("organisedcrimesuccess")]
    public int OrganisedCrimeSuccess { get; set; }

    [JsonPropertyName("rehabs")]
    public int Rehabs { get; set; }

    [JsonPropertyName("revives")]
    public int Revives { get; set; }

    [JsonPropertyName("territoryrespect")]
    public int TerritoryRespect { get; set; }

    [JsonPropertyName("traveltime")]
    public int TravelTime { get; set; }

    [JsonPropertyName("traveltimes")]
    public int TravelTimes { get; set; }
}