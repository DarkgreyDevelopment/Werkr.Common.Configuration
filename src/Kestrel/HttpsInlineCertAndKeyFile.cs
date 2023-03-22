namespace Werkr.Common.Configuration.Kestrel {
    public class HttpsInlineCertAndKeyFile : InlineCertEndpoint {
        public HttpsInlineCertAndKeyFile( string url, string path, string password, string keyPath ) : base( url ) {
            Certificate = new CertificateFile( path, password, keyPath );
        }
        public override ICertificate Certificate { get; }
    }
}
