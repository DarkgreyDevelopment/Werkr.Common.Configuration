namespace Werkr.Common.Configuration.Kestrel {
    public class HttpsInlineCertFile : InlineCertEndpoint {
        public HttpsInlineCertFile( string url, string path, string password ) : base( url ) {
            Certificate = new CertificateFile( path, password );
        }
        public override ICertificate Certificate { get; }
    }
}
