using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.PersonalStats;

public class PersonalStats : JsonModel
{
    [JsonPropertyName("activestreak")]
    public int CurrentActivityStreakInDays { get; set; }

    [JsonPropertyName("alcoholused")]
    public int AlcoholDrunk { get; set; }

    [JsonPropertyName("argtravel")]
    public int TimesTraveledToArgentina { get; set; }

    [JsonPropertyName("arrestsmade")]
    public int ArrestsMade { get; set; }

    [JsonPropertyName("attackcriticalhits")]
    public int CriticalHits { get; set; }

    [JsonPropertyName("attackdamage")]
    public int TotalDamageMade { get; set; }

    [JsonPropertyName("attackhits")]
    public int HitsMadeDuringAttacks { get; set; }

    [JsonPropertyName("attackmisses")]
    public int HitsMissedDuringAttacks { get; set; }

    [JsonPropertyName("attacksassisted")]
    public int AttacksAssisted { get; set; }

    [JsonPropertyName("attacksdraw")]
    public int AttacksStalemated { get; set; }

    [JsonPropertyName("attackslost")]
    public int AttacksLost { get; set; }

    [JsonPropertyName("attacksstealthed")]
    public int StealthAttacks { get; set; }

    [JsonPropertyName("attackswon")]
    public int AttacksWon { get; set; }

    [JsonPropertyName("attackswonabroad")]
    public int AttacksWonAbroad { get; set; }

    [JsonPropertyName("auctionsells")]
    public int ItemsAuctioned { get; set; }

    [JsonPropertyName("auctionswon")]
    public int AuctionsWon { get; set; }

    [JsonPropertyName("awards")]
    public int Awards { get; set; }

    [JsonPropertyName("axehits")]
    public int FinishingHitsWithClubbingWeapons { get; set; }

    [JsonPropertyName("bazaarcustomers")]
    public int? BazaarCustomers { get; set; }

    [JsonPropertyName("bazaarprofit")]
    public int? BazaarIncome { get; set; }

    [JsonPropertyName("bazaarsales")]
    public int? BazaarSales { get; set; }

    [JsonPropertyName("bestactivestreak")]
    public int BestActivityStreakInDays { get; set; }

    [JsonPropertyName("bestdamage")]
    public int BestDamage { get; set; }

    [JsonPropertyName("bestkillstreak")]
    public int BestKillstreak { get; set; }

    [JsonPropertyName("bloodwithdrawn")]
    public int BloodWithdrawn { get; set; }

    [JsonPropertyName("booksread")]
    public int BooksRead { get; set; }

    [JsonPropertyName("boostersused")]
    public int BoostersUsed { get; set; }

    [JsonPropertyName("bountiescollected")]
    public int BountiesCollected { get; set; }

    [JsonPropertyName("bountiesplaced")]
    public int BountiesPlaced { get; set; }

    [JsonPropertyName("bountiesreceived")]
    public int BountiesReceived { get; set; }

    [JsonPropertyName("candyused")]
    public int CandyUsed { get; set; }

    [JsonPropertyName("cantaken")]
    public int CannabisTaken { get; set; }

    [JsonPropertyName("cantravel")]
    public int TimesTraveledToCanada { get; set; }

    [JsonPropertyName("caytravel")]
    public int TimesTraveledToCaymanIslands { get; set; }

    [JsonPropertyName("chahits")]
    public int FinishingHitsWithMechanicalWeapons { get; set; }

    [JsonPropertyName("chitravel")]
    public int TimesTraveledToChina { get; set; }

    [JsonPropertyName("cityfinds")]
    public int ItemsFoundInCity { get; set; }

    [JsonPropertyName("cityitemsbought")]
    public int ShopPurchases { get; set; }

    [JsonPropertyName("classifiedadsplaced")]
    public int ClassifiedAdsPlaced { get; set; }

    [JsonPropertyName("companymailssent")]
    public int MailsToCollegues { get; set; }

    [JsonPropertyName("consumablesused")]
    public int ConsumabledUsed { get; set; }

    [JsonPropertyName("contractscompleted")]
    public int ContractsCompleted { get; set; }

    [JsonPropertyName("counterfeiting")]
    public int? Counterfeiting { get; set; }

    [JsonPropertyName("criminaloffenses")]
    public int? TotalOffenses { get; set; }

    [JsonPropertyName("cybercrime")]
    public int? Cybercrime { get; set; }

    [JsonPropertyName("daysbeendonator")]
    public int DaysBeenADonator { get; set; }

    [JsonPropertyName("defendslost")]
    public int DefendsLost { get; set; }

    [JsonPropertyName("defendslostabroad")]
    public int DefendsLostAbroad { get; set; }

    [JsonPropertyName("defendsstalemated")]
    public int DefendsStalemated { get; set; }

    [JsonPropertyName("defendswon")]
    public int DefendsWon { get; set; }

    [JsonPropertyName("defense")]
    public int? Defense { get; set; }

    [JsonPropertyName("dexterity")]
    public int? Dexterity { get; set; }

    [JsonPropertyName("drugsused")]
    public int DrugsUsed { get; set; }

    [JsonPropertyName("dubtravel")]
    public int TimesTraveledToUae { get; set; }

    [JsonPropertyName("dukecontractscompleted")]
    public int DukeContractsCompleted { get; set; }

    [JsonPropertyName("dumpfinds")]
    public int ItemsFoundInTheDump { get; set; }

    [JsonPropertyName("dumpsearches")]
    public int ItemsSearchedInTheDump { get; set; }

    [JsonPropertyName("eastereggs")]
    public int EasterEggsFound { get; set; }

    [JsonPropertyName("eastereggsused")]
    public int EasterEggsUsed { get; set; }

    [JsonPropertyName("elo")]
    public int EloRating { get; set; }

    [JsonPropertyName("endurance")]
    public int? Endurance { get; set; }

    [JsonPropertyName("energydrinkused")]
    public int EnergyDrinksDrunk { get; set; }

    [JsonPropertyName("extortion")]
    public int? Extortion { get; set; }

    [JsonPropertyName("exttaken")]
    public int EcstacyTaken { get; set; }

    [JsonPropertyName("factionmailssent")]
    public int MailsToFaction { get; set; }

    [JsonPropertyName("failedbusts")]
    public int FailedBusts { get; set; }

    [JsonPropertyName("fraud")]
    public int? Fraud { get; set; }

    [JsonPropertyName("friendmailssent")]
    public int MailsToFriends { get; set; }

    [JsonPropertyName("grehits")]
    public int FinishingHitsWithTemporaryWeapons { get; set; }

    [JsonPropertyName("h2hhits")]
    public int FinishinghitsWithHandToHand { get; set; }

    [JsonPropertyName("hawtravel")]
    public int TimesTraveledToHawaii { get; set; }

    [JsonPropertyName("heahits")]
    public int FinishingHitsWithHeavyArtillery { get; set; }

    [JsonPropertyName("highestbeaten")]
    public int HighestLevelBeaten { get; set; }

    [JsonPropertyName("hollowammoused")]
    public int HollowPointAmmoUsed { get; set; }

    [JsonPropertyName("hospital")]
    public int TimesInHospital { get; set; }

    [JsonPropertyName("illegalproduction")]
    public int? IllegalProduction { get; set; }

    [JsonPropertyName("illicitservices")]
    public int? IllicitServices { get; set; }

    [JsonPropertyName("incendiaryammoused")]
    public int IncendiaryAmmoUsed { get; set; }

    [JsonPropertyName("intelligence")]
    public int? Intelligence { get; set; }

    [JsonPropertyName("investedprofit")]
    public int? BankInvestestmentProfit { get; set; }

    [JsonPropertyName("itemsbought")]
    public int ItemsBoughtFromMarket { get; set; }

    [JsonPropertyName("itemsboughtabroad")]
    public int ItemsBoughtAbroad { get; set; }

    [JsonPropertyName("itemsdumped")]
    public int ItemsTrashed { get; set; }

    [JsonPropertyName("itemslooted")]
    public int ItemsLootedFromNpcs { get; set; }

    [JsonPropertyName("itemssent")]
    public int ItemsSent { get; set; }

    [JsonPropertyName("jailed")]
    public int TimesJailed { get; set; }

    [JsonPropertyName("japtravel")]
    public int TimesTraveledToJapan { get; set; }

    [JsonPropertyName("jobpointsused")]
    public int JobPointsUsed { get; set; }

    [JsonPropertyName("kettaken")]
    public int KetamineTaken { get; set; }

    [JsonPropertyName("killstreak")]
    public int? CurrentKillstreak { get; set; }

    [JsonPropertyName("largestmug")]
    public int LargestMug { get; set; }

    [JsonPropertyName("lontravel")]
    public int TimesTraveledToUk { get; set; }

    [JsonPropertyName("lsdtaken")]
    public int LsdTaken { get; set; }

    [JsonPropertyName("machits")]
    public int FinishingHitsWithMachineGuns { get; set; }

    [JsonPropertyName("mailssent")]
    public int MailsSent { get; set; }

    [JsonPropertyName("manuallabor")]
    public int? ManualLabor { get; set; }

    [JsonPropertyName("medicalitemsused")]
    public int MedicalItemsUsed { get; set; }

    [JsonPropertyName("meritsbought")]
    public int MeritsBought { get; set; }

    [JsonPropertyName("mextravel")]
    public int TimesTraveledToMexico { get; set; }

    [JsonPropertyName("missioncreditsearned")]
    public int MissionCreditsEarned { get; set; }

    [JsonPropertyName("missionscompleted")]
    public int MissionsCompleted { get; set; }

    [JsonPropertyName("moneyinvested")]
    public int? TotalInvestedInBank { get; set; }

    [JsonPropertyName("moneymugged")]
    public int MoneyMugged { get; set; }

    [JsonPropertyName("nerverefills")]
    public int NerveRefills { get; set; }

    [JsonPropertyName("networth")]
    public long TotalNetworth { get; set; }

    [JsonPropertyName("networthauctionhouse")]
    public long? NetworthInAuctionHouse { get; set; }

    [JsonPropertyName("networthbank")]
    public long? NetworthInBank { get; set; }

    [JsonPropertyName("networthbazaar")]
    public long? NetworthInBazaar { get; set; }

    [JsonPropertyName("networthbookie")]
    public long? NetworthInBookie { get; set; }

    [JsonPropertyName("networthcayman")]
    public long? NetworthInOverseasBank { get; set; }

    [JsonPropertyName("networthcompany")]
    public long? NetworthInCompany { get; set; }

    [JsonPropertyName("networthdisplaycase")]
    public long? NetworthInDisplayCase { get; set; }

    [JsonPropertyName("networthenlistedcars")]
    public long? NetworthInEnlistedCars { get; set; }

    [JsonPropertyName("networthitemmarket")]
    public long? NetworthInItemMarket { get; set; }

    [JsonPropertyName("networthitems")]
    public long? NetworthInInventory { get; set; }

    [JsonPropertyName("networthloan")]
    public long? NetworthInLoans { get; set; }

    [JsonPropertyName("networthpending")]
    public long? NetworthInPending { get; set; }

    [JsonPropertyName("networthpiggybank")]
    public long? NetworthInPiggyBank { get; set; }

    [JsonPropertyName("networthpoints")]
    public long? NetworthInPoints { get; set; }

    [JsonPropertyName("networthproperties")]
    public long? NetworthInProperties { get; set; }

    [JsonPropertyName("networthstockmarket")]
    public long? NetworthInStockMarket { get; set; }

    [JsonPropertyName("networthunpaidfees")]
    public long? NetworthInUnpaidFees { get; set; }

    [JsonPropertyName("networthvault")]
    public long? NetworthInVault { get; set; }

    [JsonPropertyName("networthwallet")]
    public long? NetworthInWallet { get; set; }

    [JsonPropertyName("onehitkills")]
    public int OneHitKills { get; set; }

    [JsonPropertyName("opitaken")]
    public int OpiumTaken { get; set; }

    [JsonPropertyName("organisedcrimes")]
    public int OrganizedCrimes { get; set; }

    [JsonPropertyName("overdosed")]
    public int TimesOverdosed { get; set; }

    [JsonPropertyName("pcptaken")]
    public int PcpTaken { get; set; }

    [JsonPropertyName("peoplebought")]
    public int PeopleBailed { get; set; }

    [JsonPropertyName("peopleboughtspent")]
    public int BailFees { get; set; }

    [JsonPropertyName("peoplebusted")]
    public int PeopleBusted { get; set; }

    [JsonPropertyName("personalsplaced")]
    public int PersonalsPlaced { get; set; }

    [JsonPropertyName("piehits")]
    public int FinishingHitsWithPiercingWeapons { get; set; }

    [JsonPropertyName("piercingammoused")]
    public int PiercingAmmoUsed { get; set; }

    [JsonPropertyName("pishits")]
    public int FinishingHitsWithPistols { get; set; }

    [JsonPropertyName("pointsbought")]
    public int PointsBought { get; set; }

    [JsonPropertyName("pointssold")]
    public int? PointsSold { get; set; }

    [JsonPropertyName("racesentered")]
    public int RacesEntered { get; set; }

    [JsonPropertyName("raceswon")]
    public int RacesWon { get; set; }

    [JsonPropertyName("racingpointsearned")]
    public int RacingPointsEarned { get; set; }

    [JsonPropertyName("racingskill")]
    public int RacingSkill { get; set; }

    [JsonPropertyName("raidhits")]
    public int RaidHits { get; set; }

    [JsonPropertyName("rankedwarhits")]
    public int RankedWarHits { get; set; }

    [JsonPropertyName("rankedwarringwins")]
    public int RankedWarWins { get; set; }

    [JsonPropertyName("receivedbountyvalue")]
    public int ValueOfRecivedBounties { get; set; }

    [JsonPropertyName("refills")]
    public int EnergyRefills { get; set; }

    [JsonPropertyName("rehabcost")]
    public int RehabilitationFees { get; set; }

    [JsonPropertyName("rehabs")]
    public int Rehabilitations { get; set; }

    [JsonPropertyName("respectforfaction")]
    public int TotalRespectGainedForFactions { get; set; }

    [JsonPropertyName("retals")]
    public int Retaliations { get; set; }

    [JsonPropertyName("revives")]
    public int RevivesGiven { get; set; }

    [JsonPropertyName("reviveskill")]
    public int ReviveSkill { get; set; }

    [JsonPropertyName("revivesreceived")]
    public int RevivesReceived { get; set; }

    [JsonPropertyName("rifhits")]
    public int FinishingHitsWithRifles { get; set; }

    [JsonPropertyName("roundsfired")]
    public int RoundsFired { get; set; }

    [JsonPropertyName("shohits")]
    public int FinishingHitsWithShotguns { get; set; }

    [JsonPropertyName("shrtaken")]
    public int ShroomsTaken { get; set; }

    [JsonPropertyName("slahits")]
    public int FinishingHitsWithSlashingWeapons { get; set; }

    [JsonPropertyName("smghits")]
    public int FinishingHitsWithSubMachineGuns { get; set; }

    [JsonPropertyName("soutravel")]
    public int TimesTraveledToSouthAfrica { get; set; }

    [JsonPropertyName("specialammoused")]
    public int SpecialAmmunitionUsed { get; set; }

    [JsonPropertyName("speed")]
    public int? Speed { get; set; }

    [JsonPropertyName("spetaken")]
    public int SpeedTaken { get; set; }

    [JsonPropertyName("spousemailssent")]
    public int MailsToSpouse { get; set; }

    [JsonPropertyName("statenhancersused")]
    public int StatEnhancersUsed { get; set; }

    [JsonPropertyName("stockfees")]
    public int? StockFees { get; set; }

    [JsonPropertyName("stocklosses")]
    public int? StockLosses { get; set; }

    [JsonPropertyName("stocknetprofits")]
    public int? StockNetProfits { get; set; }

    [JsonPropertyName("stockpayouts")]
    public int? StockPayouts { get; set; }

    [JsonPropertyName("stockprofits")]
    public int? StockProfits { get; set; }

    [JsonPropertyName("strength")]
    public int? Strength { get; set; }

    [JsonPropertyName("switravel")]
    public int TimesTraveledToSwitzerland { get; set; }

    [JsonPropertyName("territoryclears")]
    public int TerritoryClears { get; set; }

    [JsonPropertyName("territoryjoins")]
    public int TerrotiryWallJoins { get; set; }

    [JsonPropertyName("territorytime")]
    public int TerritoryWallTimeInSeconds { get; set; }

    [JsonPropertyName("theft")]
    public int? Theft { get; set; }

    [JsonPropertyName("theyrunaway")]
    public int FoesEscaped { get; set; }

    [JsonPropertyName("tokenrefills")]
    public int CasinoTokenRefills { get; set; }

    [JsonPropertyName("totalbountyreward")]
    public int TotalBountyReward { get; set; }

    [JsonPropertyName("totalbountyspent")]
    public int TotalSpentOnBounties { get; set; }

    [JsonPropertyName("totalstats")]
    public int? TotalBattleStats { get; set; }

    [JsonPropertyName("totalworkingstats")]
    public int? TotalWorkingStats { get; set; }

    [JsonPropertyName("tracerammoused")]
    public int TracerAmmoUsed { get; set; }

    [JsonPropertyName("trades")]
    public int? Trades { get; set; }

    [JsonPropertyName("trainsreceived")]
    public int TrainsReceived { get; set; }

    [JsonPropertyName("traveltime")]
    public int TimeSpentTravelingInSeconds { get; set; }

    [JsonPropertyName("traveltimes")]
    public int TimesTraveled { get; set; }

    [JsonPropertyName("unarmoredwon")]
    public int UnarmoredFightsWon { get; set; }

    [JsonPropertyName("useractivity")]
    public int TimePlayedInSeconds { get; set; }

    [JsonPropertyName("vandalism")]
    public int? Vandalisms { get; set; }

    [JsonPropertyName("victaken")]
    public int VicodinTaken { get; set; }

    [JsonPropertyName("virusescoded")]
    public int VirusCoded { get; set; }

    [JsonPropertyName("weaponsbought")]
    public int WeaponsBought { get; set; }

    [JsonPropertyName("xantaken")]
    public int XanaxTaken { get; set; }

    [JsonPropertyName("yourunaway")]
    public int TimesEscaped { get; set; }
}