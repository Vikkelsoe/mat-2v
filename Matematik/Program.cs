using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2D p1 = new Punkt2D(0, 0);
            Punkt2D p2 = new Punkt2D(8, 8);
            Punkt2D p3 = new Punkt2D(0, 0);
            Punkt2D p4 = new Punkt2D(-8, -8);

            Vektor2D v1 = new Vektor2D(p1,p2);
            Vektor2D v2 = new Vektor2D(p3,p4);

            /*
            Udskriv vektorer:
            v1.UdskrivVektor();
            v2.UdskrivVektor();

            Udskriv punkter:
            v1.UdskrivPunkter();
            v2.UdskrivPunkter

            Beregn længde:
            Console.WriteLine(v1.BeregnLængde());

            Beregn skalarprodukt:
            Console.WriteLine(v1.BeregnSkalarprodukt(v2));

            Beregn tværvektor:
            Vektor2D v3 = v1.BeregnTværvektor();
            v3.UdskrivVektor();
            v3.UdskrivPunkter();
            
            Beregn vektorsum:
            Vektor2D v4 = v1.BeregnVektorsum(v2);
            v4.UdskrivVektor();
            
            Beregn vektordifferens;
            Vektor2D v5 = v1.BeregnVektordifferens(v2);
            v5.UdskrivVektor();
            
            Beregn vinkel med x-akse
            Console.WriteLine(v1.BeregnVinkelMedXAkse());
            
            Undersøg, om to vektorer er ortogonale:
            Console.WriteLine(v1.ErOrtogonalMed(v1,v2));

            Undersøg, om to vektorer er parallelle:
            Console.WriteLine(v1.ErParallelMed(v1,v2));
            */

        }
    }
}
