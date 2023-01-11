namespace Werkr.Common.Wix.Configuration.Kestrel {
    public abstract class Endpoints {
        public Endpoints( string url ) { Url = url; }
        public string Url { get; set; }
        public static string Protocols { get { return "Http2"; } }

        public override string ToString( ) {
            return $"{{ \"Url\": \"{Url}\", \"Protocols\": \"{Protocols}\" }}";
        }
    }

    public abstract class InlineCertEndpoint : Endpoints {
        public InlineCertEndpoint( string url ) : base( url ) { }

        public Certificate Certificate { get; set; }

        public override string ToString( ) {
            string certificate = null == Certificate ? string.Empty : $", \"Certificate\": {Certificate} ";

            return $"{{ \"Url\": \"{Url}\", \"Protocols\": \"{Protocols}\" {certificate}}}";
        }
    }

    public class Http : Endpoints {
        public Http( string url = "http://localhost:5000" ) : base( url ) { }
    }

    public class HttpsDefaultCert : Endpoints {
        public HttpsDefaultCert( string url = "https://localhost:5001" ) : base( url ) { }
    }

    public class HttpsInlineCertFile : InlineCertEndpoint {
        public HttpsInlineCertFile( string url, string path, string password ) : base( url ) {
            Certificate = new CertificateFile( path, password );
        }
        public new CertificateFile Certificate { get; set; }
    }

    public class HttpsInlineCertAndKeyFile : InlineCertEndpoint {
        public HttpsInlineCertAndKeyFile( string url, string path, string password, string keyPath ) : base( url ) {
            Certificate = new CertificateFile( path, password, keyPath );
        }
        public new CertificateFile Certificate { get; set; }
    }

    public class HttpsInlineCertStore : InlineCertEndpoint {
        public HttpsInlineCertStore( string url, string subject, string store, string location ) : base( url ) {
            Certificate = new CertificateStore( subject, store, location );
        }
        public new CertificateStore Certificate { get; set; }
    }
}
