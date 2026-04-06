using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging
{
    class LoggingConfiguration
    {
        public LoggerType LoggerType{get;set;}

        public TextLoggerConfiguration TextLoggerConfiguration { get; set; }
    }

    public class TextLoggerConfiguration
    {
        public string Directory { get; set; }
        public string FileNamee { get; set; }
        public string FileExtension { get; set; }
    }
}
