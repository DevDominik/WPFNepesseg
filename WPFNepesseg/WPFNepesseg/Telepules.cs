using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNepesseg
{
    public class Telepules
    {
        String megye;
        String telepulesNev;
        String telepulesTipus; //község, nagyközség, város, ...
        int ferfiLakosokSzama;
        int noiLakosokSzama;

        public Telepules
            (
                string megye,
                string telepulesNev,
                string telepulesTipus,
                int ferfiLakosokSzama,
                int noiLakosokSzama
            )
        {
            this.megye = megye;
            this.telepulesNev = telepulesNev;
            this.telepulesTipus = telepulesTipus;
            this.ferfiLakosokSzama = ferfiLakosokSzama;
            this.noiLakosokSzama = noiLakosokSzama;
        }
        public String Megye { get => megye; }
        public String TelepulesNev { get => telepulesNev; }
        public String TelepulesTipus { get => telepulesTipus; }
        public int FerfiLakosokSzama { get => ferfiLakosokSzama; }
        public int NoiLakosokSzama { get => noiLakosokSzama; }
        public int LakosokSzamaEgyutt { get => ferfiLakosokSzama + noiLakosokSzama; }
    }
}
