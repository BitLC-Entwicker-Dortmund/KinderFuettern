using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderFuettern {
    class Kind {
        public string Name { get; set; }
        private int AktuellerBrennwert { get; set; }

        private List<Nahrung> magen = new List<Nahrung>();

        public void NahrungAufnehmen(Nahrung n ) {
            magen.Add ( n );
            // Brennwert extrahieren und zu AktuellerBrennwert addieren

        }
    }
}
