using System.Collections.Generic;

namespace Werkr.Common.Configuration.Kestrel {
    public class CertificateStore : ICertificate {
        public CertificateStore(
            string subject,
            string store,
            string location
        ) {
            Subject = subject;
            Store = store;
            Location = location;
        }

        public string Subject { get; set; } = string.Empty;
        public string Store { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public bool AllowInvalid { get; set; }

        public override string ToString( ) {
            List<string> strings = new List<string>();
            if (string.IsNullOrWhiteSpace( Subject ) == false) { strings.Add( $"\"Subject\": \"{Subject}\"" ); }
            if (string.IsNullOrWhiteSpace( Store ) == false) { strings.Add( $"\"Store\": \"{Store}\"" ); }
            if (string.IsNullOrWhiteSpace( Location ) == false) { strings.Add( $"\"Location\": \"{Location}\"" ); }
            strings.Add( $"\"AllowInvalid\": \"{AllowInvalid}\"" );
            string result = string.Join( ",", strings.ToArray() );
            return $"{{ {result} }}";
        }
    }
}
