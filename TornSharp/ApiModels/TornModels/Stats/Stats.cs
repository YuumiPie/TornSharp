using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.Stats;

public class Stats : JsonModel
{
    [JsonPropertyName("communication_articlereads")]
    public int CommunicationArticleReads { get; set; }

    [JsonPropertyName("communication_articles")]
    public int CommunicationArticles { get; set; }

    [JsonPropertyName("communication_articleviews")]
    public int CommunicationArticleViews { get; set; }

    [JsonPropertyName("communication_chats")]
    public int CommunicationChats { get; set; }

    [JsonPropertyName("communication_events")]
    public int CommunicationEvents { get; set; }

    [JsonPropertyName("communication_forumposts")]
    public int CommunicationForumPosts { get; set; }

    [JsonPropertyName("communication_messages")]
    public int CommunicationMessages { get; set; }

    [JsonPropertyName("communication_totalevents")]
    public int CommunicationTotalEvents { get; set; }

    [JsonPropertyName("communication_totalmessages")]
    public int CommunicationTotalMessages { get; set; }

    [JsonPropertyName("crimes")]
    public long Crimes { get; set; }

    [JsonPropertyName("crimes_today")]
    public int CrimesToday { get; set; }

    [JsonPropertyName("events")]
    public int Events { get; set; }

    [JsonPropertyName("forums_dislikes")]
    public int ForumsDislikes { get; set; }

    [JsonPropertyName("forums_likes")]
    public int ForumsLikes { get; set; }

    [JsonPropertyName("forums_posts")]
    public int ForumsPosts { get; set; }

    [JsonPropertyName("forums_threads")]
    public int ForumsThreads { get; set; }

    [JsonPropertyName("gym_trains")]
    public int GymTrains { get; set; }

    [JsonPropertyName("items")]
    public int Items { set; get; }

    [JsonPropertyName("jailed")]
    public int Jailed { get; set; }

    [JsonPropertyName("job_army")]
    public int JobArmy { get; set; }

    [JsonPropertyName("job_casino")]
    public int JobCasino { get; set; }

    [JsonPropertyName("job_company")]
    public int JobCompany { get; set; }

    [JsonPropertyName("job_education")]
    public int JobEducation { get; set; }

    [JsonPropertyName("job_grocer")]
    public int JobGrocer { get; set; }

    [JsonPropertyName("job_law")]
    public int JobLaw { get; set; }

    [JsonPropertyName("job_medical")]
    public int JobMedical { get; set; }

    [JsonPropertyName("job_none")]
    public int JobNone { get; set; }

    [JsonPropertyName("money_citybank")]
    public long MoneyCityBank { get; set; }

    [JsonPropertyName("money_onhand")]
    public long MoneyOnHand { get; set; }

    [JsonPropertyName("points_averagecost")]
    public int PointsAverageCost { get; set; }

    [JsonPropertyName("points_bought")]
    public int PointsBought { get; set; }

    [JsonPropertyName("points_market")]
    public int PointsMarket { get; set; }

    [JsonPropertyName("points_total")]
    public int PointsTotal { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("total_attacks_criticalhits")]
    public int TotalAttacksCriticalHits { get; set; }

    [JsonPropertyName("total_attacks_hits")]
    public int TotalAttacksHits { get; set; }

    [JsonPropertyName("total_attacks_lost")]
    public int TotalAttacksLost { get; set; }

    [JsonPropertyName("total_attacks_misses")]
    public int TotalAttacksMisses { get; set; }

    [JsonPropertyName("total_attacks_moneymugged")]
    public long TotalAttacksMoneyMugged { get; set; }

    [JsonPropertyName("total_attacks_respectgained")]
    public int TotalAttacksRespectGained { get; set; }

    [JsonPropertyName("total_attacks_roundsfired")]
    public long TotalAttacksRoundsFired { get; set; }

    [JsonPropertyName("total_attacks_runaway")]
    public int TotalAttacksRunaway { get; set; }

    [JsonPropertyName("total_attacks_stalemated")]
    public int TotalAttacksStalemated { get; set; }

    [JsonPropertyName("total_attacks_stealthed")]
    public int TotalAttacksStealthed { get; set; }

    [JsonPropertyName("total_attacks_won")]
    public int TotalAttacksWon { get; set; }

    [JsonPropertyName("total_bounty_placed")]
    public int TotalBountyPlaced { get; set; }

    [JsonPropertyName("total_bounty_rewards")]
    public long TotalBountyRewards { get; set; }

    [JsonPropertyName("total_classifiedads_placed")]
    public int TotalClassifiedAdsPlaced { get; set; }

    [JsonPropertyName("total_company_trains")]
    public int TotalCompanyTrains { get; set; }

    [JsonPropertyName("total_drugs_cannabis")]
    public int TotalDrugsCannabis { get; set; }

    [JsonPropertyName("total_drugs_ecstacy")]
    public int TotalDrugsEcstacy { get; set; }

    [JsonPropertyName("total_drugs_ketamine")]
    public int TotalDrugsKetamine { get; set; }

    [JsonPropertyName("total_drugs_lsd")]
    public int TotalDrugsLsd { get; set; }

    [JsonPropertyName("total_drugs_opium")]
    public int TotalDrugsOpium { get; set; }

    [JsonPropertyName("total_drugs_overdosed")]
    public int TotalDrugsOverdosed { get; set; }

    [JsonPropertyName("total_drugs_pcp")]
    public int TotalDrugsPcp { get; set; }

    [JsonPropertyName("total_drugs_shrooms")]
    public int TotalDrugsShrooms { get; set; }

    [JsonPropertyName("total_drugs_speed")]
    public int TotalDrugsSpeed { get; set; }

    [JsonPropertyName("total_drugs_used")]
    public int TotalDrugsUsed { get; set; }

    [JsonPropertyName("total_drugs_vicodin")]
    public int TotalDrugsVicodin { get; set; }

    [JsonPropertyName("total_drugs_xanax")]
    public int TotalDrugsXanax { get; set; }

    [JsonPropertyName("total_hospital_medicalitemsused")]
    public int TotalHospitalMedicalItemsUsed { get; set; }

    [JsonPropertyName("total_hospital_revived")]
    public int TotalHospitalRevived { get; set; }

    [JsonPropertyName("total_hospital_trips")]
    public int TotalHospitalTrips { get; set; }

    [JsonPropertyName("total_items_auctionswon")]
    public int TotalItemsAuctionsWon { get; set; }

    [JsonPropertyName("total_items_bazaarbought")]
    public long TotalItemsBazaarBought { get; set; }

    [JsonPropertyName("total_items_bazaarincome")]
    public long TotalItemsBazaarIncome { get; set; }

    [JsonPropertyName("total_items_cityfinds")]
    public int TotalItemsCityFinds { get; set; }

    [JsonPropertyName("total_items_dumped")]
    public int TotalItemsDumped { get; set; }

    [JsonPropertyName("total_items_dumpfinds")]
    public int TotalItemsDumpFinds { get; set; }

    [JsonPropertyName("total_items_marketbought")]
    public int TotalItemsMarketBought { get; set; }

    [JsonPropertyName("total_items_sent")]
    public int TotalItemsSent { get; set; }

    [JsonPropertyName("total_jail_bailcosts")]
    public long TotalJailBailCosts { get; set; }

    [JsonPropertyName("total_jail_bailed")]
    public int TotalJailBailed { get; set; }

    [JsonPropertyName("total_jail_busted")]
    public int TotalJailBusted { get; set; }

    [JsonPropertyName("total_jail_busts")]
    public int TotalJailBusts { get; set; }

    [JsonPropertyName("total_jail_jailed")]
    public int TotalJailJailed { get; set; }

    [JsonPropertyName("total_mails_sent")]
    public int TotalMailsSent { get; set; }

    [JsonPropertyName("total_mails_sent_company")]
    public int TotalMailsSentCompany { get; set; }

    [JsonPropertyName("total_mails_sent_faction")]
    public int TotalMailsSentFaction { get; set; }

    [JsonPropertyName("total_mails_sent_friends")]
    public int TotalMailsSentFriends { get; set; }

    [JsonPropertyName("total_mails_sent_spouse")]
    public int TotalMailsSentSpouse { get; set; }

    [JsonPropertyName("total_merits_bought")]
    public int TotalMeritsBought { get; set; }

    [JsonPropertyName("total_points_boughttotal")]
    public long TotalPointsBoughtTotal { get; set; }

    [JsonPropertyName("total_refills_bought")]
    public int TotalRefillsBought { get; set; }

    [JsonPropertyName("total_statenhancers_used")]
    public int TotalStatenhancersUsed { get; set; }

    [JsonPropertyName("total_trades")]
    public int TotalTrades { get; set; }

    [JsonPropertyName("total_travel_all")]
    public int TotalTravelAll { get; set; }

    [JsonPropertyName("total_travel_argentina")]
    public int TotalTravelArgentina { get; set; }

    [JsonPropertyName("total_travel_canada")]
    public int TotalTravelCanada { get; set; }

    [JsonPropertyName("total_travel_caymanislands")]
    public int TotalTravelCaymanIslands { get; set; }

    [JsonPropertyName("total_travel_china")]
    public int TotalTravelChina { get; set; }

    [JsonPropertyName("total_travel_dubai")]
    public int TotalTravelDubai { get; set; }

    [JsonPropertyName("total_travel_hawaii")]
    public int TotalTravelHawaii { get; set; }

    [JsonPropertyName("total_travel_japan")]
    public int TotalTravelJapan { get; set; }

    [JsonPropertyName("total_travel_mexico")]
    public int TotalTravelMexico { get; set; }

    [JsonPropertyName("total_travel_southafrica")]
    public int TotalTravelSouthAfrica { get; set; }

    [JsonPropertyName("total_travel_switzerland")]
    public int TotalTravelSwitzerland { get; set; }

    [JsonPropertyName("total_travel_unitedkingdom")]
    public int TotalTravelUnitedKingdom { get; set; }

    [JsonPropertyName("total_users_logins")]
    public int TotalUsersLogins { get; set; }

    [JsonPropertyName("total_users_playtime")]
    public int TotalUsersPlaytime { get; set; }

    [JsonPropertyName("users_daily")]
    public int UsersDaily { get; set; }

    [JsonPropertyName("users_enby")]
    public int UsersEnby { get; set; }

    [JsonPropertyName("users_female")]
    public int UsersFemale { get; set; }

    [JsonPropertyName("users_male")]
    public int UsersMale { get; set; }

    [JsonPropertyName("users_marriedcouples")]
    public int UsersMarriedCouples { get; set; }

    [JsonPropertyName("users_total")]
    public int UsersTotal { get; set; }

    [JsonPropertyName("wars_raid")]
    public int WarsRaid { get; set; }

    [JsonPropertyName("wars_ranked")]
    public int WarsRanked { get; set; }

    [JsonPropertyName("wars_territory")]
    public int WarsTerritory { get; set; }
}