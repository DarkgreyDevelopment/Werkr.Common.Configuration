using MLogging = Microsoft.Extensions.Logging;

namespace Werkr.Common.Configuration {
    public class LogLevel {
        public MLogging.LogLevel Default { get; set; } = MLogging.LogLevel.Trace;
        public MLogging.LogLevel MicrosoftHostingLifetime { get; set; } = MLogging.LogLevel.Warning;
        public MLogging.LogLevel MicrosoftAspNetCore { get; set; } = MLogging.LogLevel.Warning;

        public override string ToString( ) {
            return $"{{ \"Default\": \"{Default}\", \"Microsoft.Hosting.Lifetime\": \"{MicrosoftHostingLifetime}\", \"Microsoft.AspNetCore\": \"{MicrosoftAspNetCore}\" }}";
        }
    }
}
