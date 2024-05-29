namespace TornSharp.Exceptions;

/// <summary>
/// Exception that is beeing throw 1
/// 
/// </summary>
public class TornSharpToManyRequestException : Exception
{
    /// <summary>
    /// To many calls were made 
    /// </summary>
    public TornSharpToManyRequestException()
    {
    }

    /// <summary>
    /// To many call were made
    /// </summary>
    /// <param name="message"></param>
    public TornSharpToManyRequestException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// To many calls were made
    /// </summary>
    /// <param name="message"></param>
    /// <param name="inner"></param>
    public TornSharpToManyRequestException(string message, Exception inner)
        : base(message, inner)
    {
    }
}