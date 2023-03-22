using System.Collections.Generic;

namespace Werkr.Common.Configuration.Kestrel {
    public class KestrelConfig {
        public KestrelConfig( ) : this( new List<Endpoints>( ) { new Http( ) }.ToArray( ) ) { }
        public KestrelConfig( Endpoints[] endpoints ) {
            Endpoints = endpoints;
        }
        public Endpoints[] Endpoints { get; set; }
        public override string ToString( ) {
            string result = "";
            foreach (Endpoints endpoint in Endpoints) {
                result += $"\"{endpoint.GetType( ).Name}\": {endpoint}, ";
            }
            result = result.TrimEnd( new char[] { ',', ' ' } );
            return $"{{ \"Endpoints\": {{ {result} }} }}";
        }
    }
}
