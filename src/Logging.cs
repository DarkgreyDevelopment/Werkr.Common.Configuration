namespace Werkr.Common.Wix.Configuration {
    public class Logging {
        public OTLP OTLP { get; set; } = new OTLP( );
        public LogLevel LogLevel { get; set; } = new LogLevel( );
        public override string ToString( ) {
            return $"{{ \"OTLP\": {OTLP}, \"LogLevel\": {LogLevel} }}";
        }
    }

    public class OTLP {
        public bool EnableTelemetry { get; set; }
        public string CollectorAddress { get; set; } = string.Empty;
        public override string ToString( ) {
            return $"{{ \"EnableTelemetry\": \"{EnableTelemetry}\", \"CollectorAddress\": \"{CollectorAddress}\" }}";
        }
    }

    public class LogLevel {
        public Microsoft.Extensions.Logging.LogLevel Default { get; set; } = Microsoft.Extensions.Logging.LogLevel.Trace;
        public Microsoft.Extensions.Logging.LogLevel MicrosoftHostingLifetime { get; set; } = Microsoft.Extensions.Logging.LogLevel.Warning;
        public Microsoft.Extensions.Logging.LogLevel MicrosoftAspNetCore { get; set; } = Microsoft.Extensions.Logging.LogLevel.Warning;

        public override string ToString( ) {
            return $"{{ \"Default\": \"{Default}\", \"Microsoft.Hosting.Lifetime\": \"{MicrosoftHostingLifetime}\", \"Microsoft.AspNetCore\": \"{MicrosoftAspNetCore}\" }}";
        }
    }
}
