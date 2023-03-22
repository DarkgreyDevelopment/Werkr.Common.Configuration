namespace Werkr.Common.Configuration {
    public class OTLP {
        public bool EnableTelemetry { get; set; }
        public string CollectorAddress { get; set; } = string.Empty;
        public override string ToString( ) {
            return $"{{ \"EnableTelemetry\": \"{EnableTelemetry}\", \"CollectorAddress\": \"{CollectorAddress}\" }}";
        }
    }
}
