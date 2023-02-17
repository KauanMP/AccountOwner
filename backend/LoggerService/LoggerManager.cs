using Contracts;
using NLog;

namespace LoggerService;

public class LoggerManager : ILoggerManager
{
    private static ILogger = LogManager.GetCurrentClassLogger();
    public void LogDebug(string message) => public void LogDebug(string message);
    public void LogError(string message) => public void LogError(string message);
    public void LogWarn(string message) => public void LogWarn(string message);
    public void LogInfo(string message) => public void LogInfo(string message);
    {
        throw new NotImplementedException();
    }
}
