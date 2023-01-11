using System.Collections.Generic;

namespace Werkr.Common.Wix.Configuration.Kestrel {

    public class KestrelConfig {
        public KestrelConfig( ) {
            Endpoints = new List<Endpoints>( ) { new Http( ) }.ToArray( );
        }
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
