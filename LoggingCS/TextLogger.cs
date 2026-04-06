using System;
using System.Collections.Generic;
using System.Text;

using TradingEngineServer.Logging;
using Microsoft.Extensions.Options;

namespace TradingEngineServer.Logging.LoggingConfiguration;

public class TextLogger : AstractLogger, ITextLogger
{

    // private readonly

    private readonly LoggerConfiguration _loggingConfiguration;

    public TextLogger(Ioptions<LoggerConfiguration> loggingConfiguration): base()
    {
        _loggingConfiguration = loggingConfiguration.Value ?? throw new ArgumentNullException(nameof(loggingConfiguration));
    }
    protected overrirde void Log(LogLevel logLevel, string module, string message)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
