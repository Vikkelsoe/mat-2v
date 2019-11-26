using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface ICirkel
    {
        public Punkt2D Centrum { get; set; }
        public double Radius { get; set; }
        public int Areal { get; set; }
        public double Omkreds { get; set; }


        public bool Skæring(IPunkt2D punkt);

        public bool Skæring(ICirkel cirkel);

        public bool Skæring(ILineærFunktion lineærFunktion);

        public List<Punkt2D> Skæringspunkter(ICirkel cirkel);

        public double ArealAfCirkeludsnit(double vinkel, bool grader=true);

        public double ArealAfCirkelafsnit(double vinkel, bool grader = true);

        public double Buelængde(double vinkel, bool grader = true);


    }
}
