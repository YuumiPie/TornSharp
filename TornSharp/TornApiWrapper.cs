using TornSharp.ApiModels.CompanyModels;
using TornSharp.ApiModels.FactionModels;
using TornSharp.ApiModels.KeyModels;
using TornSharp.ApiModels.MarketModels;
using TornSharp.ApiModels.PropertyModels;
using TornSharp.ApiModels.TornModels;
using TornSharp.ApiModels.UserModels;
using TornSharp.Enums;
using TornSharp.Exceptions;
using TornSharp.Extensions;
using TornSharp.Utils;

namespace TornSharp;

/// <summary>
/// Wrapper class that does all the Torn api calls
/// </summary>
public class TornApiWrapper
{
    #region Accessors

    /// <summary>
    /// Maximum number of calls that can be used;
    /// </summary>
    public int MaxNumberOfCalls { get; set; }

    /// <summary>
    /// Object that keeps track of the api key beeing used
    /// </summary>
    public API ApiKey
    {
        get { return apiKey; }

        private set { this.apiKey = value; }
    }

    public bool MissingFieldsLogging { get; set; }

    #endregion

    #region Mutators

    private API apiKey;
    private ObjectFromUrl apiCaller = new();
    private JsonDataLogger dataLogger = new();
    private string urlBase = @"https://api.torn.com/";

    #endregion

    #region Constructors

    /// <summary>
    /// Create a TornWrapper instance
    /// </summary>
    /// <param name="apiKey">Api to use</param>
    /// <param name="maxNumberOfCalls">Number of call limit (Throws error when going over this amount).</param>
    /// <param name="missingFieldsLogging">Logging api call information</param>
    public TornApiWrapper(string apiKey, int maxNumberOfCalls = Int32.MaxValue, bool missingFieldsLogging = true)
    {
        ApiKey = new API(apiKey);
        MaxNumberOfCalls = maxNumberOfCalls;
        MissingFieldsLogging = missingFieldsLogging;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Call methods from the Faction Api
    /// </summary>
    /// <typeparam name="T">Object that implements IFactionStatistics</typeparam>
    /// <param name="factionId">Id of the faction or "" for user faction</param>
    /// <returns>Object containing response of type T</returns>
    public async Task<T> GetFromFactionApi<T>(string factionId) where T : IFactionStatistics, new()
    {
        T method = new();
        string url = $"{urlBase}{Fields.Faction.GetEnumMemberValue()}/{factionId}?selections={method.GetMethodName()}&key={apiKey.ApiKey}";
        T response = await DoCall<T>(url);

        return response;
    }

    /// <summary>
    /// Call methods from the property Api
    /// </summary>
    /// <typeparam name="T">Object implementing IPropertyStatistics interface</typeparam>
    /// <param name="propertyId">A Property Id</param>
    /// <returns>Object of type T</returns>
    public async Task<T> GetFromPropertyApi<T>(string propertyId) where T : IPropertyStatistics, new()
    {
        T method = new();
        if (string.IsNullOrWhiteSpace(propertyId))
        {
            throw new ArgumentException("Property id cannot be null of whitespace");
        }

        string url = $"{urlBase}{Fields.Property.GetEnumMemberValue()}/{propertyId}?selections={method.GetMethodName()}&key={apiKey.ApiKey}";

        T response = await DoCall<T>(url);

        return response;
    }

    /// <summary>
    /// Call methods from the company Api
    /// </summary>
    /// <typeparam name="T">Object implementing ICompanyStatistics interface</typeparam>
    /// <param name="companyId">A company Id</param>
    /// <returns>Object of type T</returns>
    public async Task<T> GetFromCompanyApi<T>(string companyId) where T : ICompanyStatistics, new()
    {
        T method = new();

        string url = $"{urlBase}{Fields.Company.GetEnumMemberValue()}/{companyId}?selections={method.GetMethodName()}&key={apiKey.ApiKey}";

        T response = await DoCall<T>(url);

        return response;
    }

    /// <summary>
    /// Call methods from the market Api
    /// </summary>
    /// <typeparam name="T">Object implementing IMarketStatistics interface</typeparam>
    /// <param name="itemId">An item Id</param>
    /// <returns>Object of type T</returns>
    public async Task<T> GetFromMarketApi<T>(string itemId) where T : IMarketStatistics, new()
    {
        T method = new();

        string url = $"{urlBase}{Fields.Market.GetEnumMemberValue()}/{itemId}?selections={method.GetMethodName()}&key={apiKey.ApiKey}";

        T response = await DoCall<T>(url);

        return response;
    }

    /// <summary>
    /// Call methods from the user Api
    /// </summary>
    /// <typeparam name="T">Object implementing IUserStatistics interface</typeparam>
    /// <param name="userId">A user Id</param>
    /// <returns>Object of type T</returns>
    public async Task<T> GetFromUserApi<T>(string? userId = null) where T : IUserStatistics, new()
    {
        T method = new();

        string url = $"{urlBase}{Fields.User.GetEnumMemberValue()}/{userId}?selections={method.GetMethodName()}&key={apiKey.ApiKey}";

        T response = await DoCall<T>(url);

        return response;
    }

    /// <summary>
    /// Call methods from the torn Api
    /// </summary>
    /// <typeparam name="T">Object implementing ITornStats interface</typeparam>
    /// <param name="parameter">Could be an item number, honor number depending on the api that is beeing called</param>
    /// <returns>Object of type T</returns>
    public async Task<T> GetFromTornApi<T>(string parameter) where T : ITornStats, new()
    {
        T method = new();

        string url = $"{urlBase}{Fields.Torn.GetEnumMemberValue()}/{parameter}?selections={method.GetMethodName()}&key={apiKey.ApiKey}";

        T response = await DoCall<T>(url);

        return response;
    }

    /// <summary>
    /// Call methods from the key Api
    /// </summary>
    /// <typeparam name="T">Object implementing IKeyStatistics interface</typeparam>
    /// <param name="parameter">Could be an item number, honor number depending on the api that is beeing called</param>
    /// <returns>Object of type T</returns>
    public async Task<T> GetFromKeyApi<T>(string parameter) where T : IKeyStatistics, new()
    {
        T method = new();

        string url = $"{urlBase}{Fields.Key.GetEnumMemberValue()}/{parameter}?selections={method.GetMethodName()}&key={apiKey.ApiKey}";

        T response = await DoCall<T>(url);

        return response;
    }

    private async Task<T> DoCall<T>(string url)
    {
        if (apiKey.GetApiCount() > MaxNumberOfCalls)
        {
            throw new TornSharpToManyRequestException(
                $"Too many calls have been made with this api key maximum amount: {this.MaxNumberOfCalls}");
        }

        T response = await apiCaller.GetObject<T>(url);

        apiKey.AddApiCount();

        if (!MissingFieldsLogging)
        {
            return response;
        }

        try
        {
            dataLogger.LogMissingFields(response);
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't log missing fields for type {response!.GetType()}", ex);
        }
        return response;
    }

    #endregion
}