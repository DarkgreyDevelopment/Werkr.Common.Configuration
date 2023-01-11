namespace Werkr.Common.Wix.Configuration.Kestrel {
    public abstract class Certificate {
        public bool AllowInvalid { get; set; }
    }

    public class CertificateFile : Certificate {
        public CertificateFile(
            string path,
            string password = null,
            string keyPath = null
        ) {
            Path = path;
            Password = password;
            KeyPath = keyPath;
        }

        public string Path { get; set; }
        public string Password { get; set; }
        public string KeyPath { get; set; }

        public override string ToString( ) {
            string path     = string.IsNullOrWhiteSpace(Path)     ? string.Empty : $"\"Path\": \"{Path}\"";
            string password = string.IsNullOrWhiteSpace(Password) ? string.Empty : $"\"Password\": \"{Password}\"";
            string keyPath  = string.IsNullOrWhiteSpace(KeyPath)  ? string.Empty : $"\"KeyPath\": \"{KeyPath}\"";
            string allowInvalid = $"\"AllowInvalid\": \"{AllowInvalid}\"";

            string result = string.Join( ",", new string[] { path, password, keyPath, allowInvalid } );
            return $"{{ {result} }}";
        }
    }

    public class CertificateStore : Certificate {
        public CertificateStore(
            string subject,
            string store,
            string location
        ) {
            Subject = subject;
            Store = store;
            Location = location;
        }

        public string Subject { get; set; }
        public string Store { get; set; }
        public string Location { get; set; }

        public override string ToString( ) {

            string path     = string.IsNullOrWhiteSpace(Subject)  ? string.Empty : $"\"Subject\": \"{Subject}\"";
            string password = string.IsNullOrWhiteSpace(Store)    ? string.Empty : $"\"Store\": \"{Store}\"";
            string keyPath  = string.IsNullOrWhiteSpace(Location) ? string.Empty : $"\"Location\": \"{Location}\"";
            string allowInvalid = $"\"AllowInvalid\": \"{AllowInvalid}\"";

            string result = string.Join( ",", new string[] { path, password, keyPath, allowInvalid } );
            return $"{{ {result} }}";
        }
    }
}
