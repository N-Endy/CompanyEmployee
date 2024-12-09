using Serilog;

namespace Application.LoggerService.LoggerManager;

public class LoggerManager : ILoggerManager
{
    private static readonly ILogger Logger = Log.ForContext<LoggerManager>();
    
    public void LogInfo(string message) => Logger.Information(message);

    public void LogWarn(string message) => Logger.Warning(message);

    public void LogError(string message) => Logger.Error(message);

    public void LogDebug(string message) => Logger.Debug(message);
}