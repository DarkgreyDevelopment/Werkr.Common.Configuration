namespace Werkr.Common.Configuration {
    public class Logging {
        public OTLP OTLP { get; set; } = new OTLP( );
        public LogLevel LogLevel { get; set; } = new LogLevel( );
        public override string ToString( ) {
            return $"{{ \"OTLP\": {OTLP}, \"LogLevel\": {LogLevel} }}";
        }
    }
}
