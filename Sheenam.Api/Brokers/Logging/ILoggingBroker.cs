namespace Sheenam.Api.Brokers.Logging;

public interface ILoggingBroker
{
    public void LogCritical(Exception exception);
    public void LogError(Exception exception);
}