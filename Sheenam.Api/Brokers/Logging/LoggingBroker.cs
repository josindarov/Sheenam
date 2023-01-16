namespace Sheenam.Api.Brokers.Logging;

public class LoggingBroker : ILoggingBroker
{
    private readonly ILogger<LoggingBroker> _logger;

    public LoggingBroker(ILogger<LoggingBroker> logger)
    {
        _logger = logger;
    }

    public void LogError(Exception exception)
    {
        this._logger.LogError(exception,exception.Message);
    }
    public void LogCritical(Exception exception)
    {
        this._logger.LogCritical(exception,exception.Message);
    }

}
