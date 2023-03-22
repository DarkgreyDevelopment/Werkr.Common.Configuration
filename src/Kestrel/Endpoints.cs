namespace Werkr.Common.Configuration.Kestrel {
    public abstract class Endpoints {
        public Endpoints( string url ) { Url = url; }
        public string Url { get; set; }
        public static string Protocols { get { return "Http2"; } }

        public override string ToString( ) {
            return $"{{ \"Url\": \"{Url}\", \"Protocols\": \"{Protocols}\" }}";
        }
    }
}
