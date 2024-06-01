namespace TornSharp.Utils;

/// <summary>
/// This class holds some very simple information for the working of the API
/// </summary>
public class API
{
    /// <summary>
    /// This holds a reference to the apiKey that you must provide
    /// </summary>
    public string ApiKey { get; private set; }

    public bool Logging { get; private set; }

    private int ApiCallCount;

    /// <summary>
    /// Last the api key was reset to zero
    /// </summary>
    private DateTime _lastReset;

    /// <summary>
    /// API constructor
    /// </summary>
    /// <param name="apiKey">Api key to use</param>
    public API(string apiKey)
    {
        ApiKey = apiKey;
        _lastReset = DateTime.Now;
        ApiCallCount = 0;
    }

    /// <summary>
    /// Changes the Api key currently used
    /// </summary>
    /// <param name="apiKey">Key you are about to use</param>
    public void ChangeApiKey(string apiKey)
    {
        ApiKey = apiKey;
        ApiCallCount = 0;
        _lastReset = DateTime.Now;
    }

    /// <summary>
    /// returns number of calls the last min
    /// </summary>
    /// <returns>new api count</returns>
    public int AddApiCount()
    {
        TimeSpan time = DateTime.Now - _lastReset;
        if (time.Minutes >= 1)
        {
            _lastReset = DateTime.Now;
            ApiCallCount = 1;
            return ApiCallCount;
        }
        ApiCallCount++;
        return ApiCallCount;
    }

    /// <summary>
    /// Returns current api count
    /// </summary>
    /// <returns>api count</returns>
    public int GetApiCount()
    {
        TimeSpan time = DateTime.Now - _lastReset;
        if (time.Minutes >= 1)
        {
            _lastReset = DateTime.Now;
            ApiCallCount = 0;
            return ApiCallCount;
        }
        return ApiCallCount;
    }
}