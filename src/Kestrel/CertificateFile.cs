using System.Collections.Generic;

namespace Werkr.Common.Configuration.Kestrel {
    public class CertificateFile : ICertificate {
        public CertificateFile(
            string path,
            string password = null,
            string keyPath = null
        ) {
            Path = path;
            Password = password;
            KeyPath = keyPath;
        }

        public string Path { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string KeyPath { get; set; } = string.Empty;
        public bool AllowInvalid { get; set; }

        public override string ToString( ) {
            List<string> strings = new List<string>();
            if (string.IsNullOrWhiteSpace( Path ) == false) { strings.Add( $"\"Path\": \"{Globals.EscapePath( Path )}\"" ); }
            if (string.IsNullOrWhiteSpace( Password ) == false) { strings.Add( $"\"Password\": \"{Password}\"" ); }
            if (string.IsNullOrWhiteSpace( KeyPath ) == false) { strings.Add( $"\"KeyPath\": \"{KeyPath}\"" ); }
            strings.Add( $"\"AllowInvalid\": \"{AllowInvalid}\"" );
            string result = string.Join( ",", strings.ToArray() );
            return $"{{ {result} }}";
        }
    }
}
