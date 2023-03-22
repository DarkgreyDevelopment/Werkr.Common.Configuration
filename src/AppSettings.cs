using Werkr.Common.Configuration.Kestrel;

namespace Werkr.Common.Configuration {
    public class AppSettings {
        public Operators Operators { get; set; } = new Operators( );
        public Logging Logging { get; set; } = new Logging( );
        public string AllowedHosts { get; set; } = "*";
        public KestrelConfig Kestrel { get; set; } = new KestrelConfig( );
        public string ToString( bool showOperators ) => showOperators
            ? $"{{ \"Operators\": {Operators}, \"Logging\": {Logging}, \"AllowedHosts\": \"{AllowedHosts}\", \"Kestrel\": {Kestrel} }}"
            : $"{{ \"Logging\": {Logging}, \"AllowedHosts\": \"{AllowedHosts}\", \"Kestrel\": {Kestrel} }}";
    }
}
