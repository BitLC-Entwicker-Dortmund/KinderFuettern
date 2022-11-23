using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderFuettern {
    class Fuetterer {
        internal void Fuettern ( Kind kind , Nahrung nahrung ) {
            kind.NahrungAufnehmen ( nahrung );
        }

        internal void WasHastduGegessen ( Kind kind) {
            kind.IchHabeGegessen ( );
        }
    }
}
