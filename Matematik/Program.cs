using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Punkt2D p1 = new Punkt2D(0, 0);
            Punkt2D p2 = new Punkt2D(1, 1);
            Punkt2D p3 = new Punkt2D(5, 8);
            Punkt2D p4 = new Punkt2D(4, 1);

            Vektor2D v1 = new Vektor2D(p1,p2);
            Vektor2D v2 = new Vektor2D(p3,p4);

            Console.WriteLine(v1.BeregnLængde());
            Console.WriteLine(v1.BeregnSkalarprodukt(v2));
    

        }
    }
}
