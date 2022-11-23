using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderFuettern {
    class Program {
        static void Main ( string [ ] args ) {
            Nahrung birne = new Nahrung ( 100 );
            Nahrung pizza = new Nahrung ( 10000 );

            Kind ahmed = new Kind ( );

            Fuetterer peter = new Fuetterer ( );


            peter.Fuettern ( ahmed, birne );
            peter.Fuettern ( ahmed, pizza );

            peter.WasHastduGegessen ( ahmed );

            Console.Read ( );

            ahmed.Toben ( );
            peter.WasHastduGegessen ( ahmed );

            ahmed.Toben ( );
            peter.WasHastduGegessen ( ahmed );

            Console.Read ( );
        }
    }
}
