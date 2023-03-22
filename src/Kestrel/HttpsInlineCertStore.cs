namespace Werkr.Common.Configuration.Kestrel {
    public class HttpsInlineCertStore : InlineCertEndpoint {
        public HttpsInlineCertStore( string url, string subject, string store, string location ) : base( url ) {
            Certificate = new CertificateStore( subject, store, location );
        }
        public override ICertificate Certificate { get; }
    }
}
