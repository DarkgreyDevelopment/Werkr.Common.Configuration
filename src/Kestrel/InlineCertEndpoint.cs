namespace Werkr.Common.Configuration.Kestrel {
    public abstract class InlineCertEndpoint : Endpoints {
        public InlineCertEndpoint( string url ) : base( url ) { }

        public abstract ICertificate Certificate { get; }
        public override string ToString( ) {
            string certificate = null == Certificate ? string.Empty : $", \"Certificate\": {Certificate} ";

            return $"{{ \"Url\": \"{Url}\", \"Protocols\": \"{Protocols}\"{certificate}}}";
        }
    }
}
