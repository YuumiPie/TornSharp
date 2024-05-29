namespace TornSharp.Exceptions;

public class TornSharpErrorJsonException : Exception
{
    public string JsonPayload { get; }
    internal TornSharpErrorJsonException(string message, string jsonPayload)
        : base(message)
    {
        JsonPayload = jsonPayload;
    }
}