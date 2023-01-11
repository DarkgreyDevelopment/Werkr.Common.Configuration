namespace Werkr.Common.Wix.Configuration {
    public class Operators {
        public string WorkingDirectory { get; set; } = string.Empty;
        public bool EnablePowerShell { get; set; } = true;
        public bool EnableSystemShell { get; set; } = true;
        public override string ToString( ) {
            return $"{{ \"WorkingDirectory\": \"{WorkingDirectory}\", \"EnablePowerShell\": \"{EnablePowerShell}\", \"EnableSystemShell\": \"{EnableSystemShell}\" }}";
        }
    }
}
