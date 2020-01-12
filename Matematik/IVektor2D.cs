using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IVektor2D
    {
        public IPunkt2D Punkt { get; set; }
        public IPunkt2D Startpunkt { get; set; }
        public IPunkt2D Slutpunkt { get; set; }             
        public double Længde { get; set; }

        public double BeregnLængde();
        public double BeregnVinkelMedXAkse();
        public bool ErParallelMed(IVektor2D vektor1, IVektor2D vektor2);
        public bool ErOrtogonalMed(IVektor2D vektor1, IVektor2D vektor2);

        public Vektor2D BeregnTværvektor();

        public double BeregnSkalarprodukt(IVektor2D vektor);

        public Vektor2D BeregnVektorsum(IVektor2D vektor);

        public Vektor2D BeregnVektordifferens(IVektor2D vektor);

    }
}
