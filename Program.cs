using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderFuettern {
    class Program {
        static void Main ( string [ ] args ) {
            Nahrung birne = new Nahrung ( 100 );
            Kind kind = new Kind ( );
            Fuetterer peter = new Fuetterer ( );
            peter.Fuettern ( kind, birne );

        }
    }
}
