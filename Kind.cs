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
            // nehme ein Nahrungsobjekt in die Liste auf
            magen.Add ( n );

            // Brennwert extrahieren und zu AktuellerBrennwert addieren
            AktuellerBrennwert += n.Brennwert;
        }

        internal void IchHabeGegessen ( ) {
            foreach ( Nahrung nahrung in magen ) {
                Console.WriteLine ( nahrung.Brennwert );
            }

            Console.WriteLine ( "Brennwert gesamt: {0}", AktuellerBrennwert );
        }

        public void Toben ( ) {
            AktuellerBrennwert = AktuellerBrennwert - magen [ 0 ].Brennwert;
            magen.RemoveAt ( 0 );
        }


    }
}
