using System.Text.RegularExpressions;

namespace Werkr.Common.Configuration {
    internal static class Globals {
        internal static string EscapePath( string input ) => Regex.Replace( input, @"(?<!\\)\\(?!\\)", @"\$0" ); // replace any single backslashes with 2.
    }
}
