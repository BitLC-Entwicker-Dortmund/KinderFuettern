using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderFuettern {
    class Nahrung {
        public int Brennwert { get; set; }

        public Nahrung (int kalorie ) {
            Brennwert = kalorie;
        }
    }
}
