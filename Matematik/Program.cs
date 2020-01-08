using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2D p1 = new Punkt2D(0, 0);
            Punkt2D p2 = new Punkt2D(8, 8);
            Punkt2D p3 = new Punkt2D(5, 8);
            Punkt2D p4 = new Punkt2D(4, 1);

            Vektor2D v1 = new Vektor2D(p1,p2);
            Vektor2D v2 = new Vektor2D(p3,p4);

            /*
            v1.UdskrivVektor();
            v2.UdskrivVektor();

            Console.WriteLine(v1.BeregnLængde());
            Console.WriteLine(v1.BeregnSkalarprodukt(v2));
    
            Vektor2D v3 = v1.BeregnTværvektor();
            v3.UdskrivVektor();
            v3.UdskrivPunkter();
            
            Vektor2D v4 = v1.BeregnVektorsum(v2);
            v4.UdskrivVektor();
            
            Vektor2D v5 = v1.BeregnVektordifferens(v2);
            v5.UdskrivVektor();
            */

            Console.WriteLine(v1.BeregnVinkelMedXAkse());
    

        }
    }
}
