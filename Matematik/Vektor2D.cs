using Matematik;
using System;

class Vektor2D : IVektor2D
{
    private const double V = 0.5;

    public IPunkt2D Punkt { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public IPunkt2D Startpunkt { get; set; }
    public IPunkt2D Slutpunkt { get; set; }
    public double Længde { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public Vektor2D(IPunkt2D startpunkt, IPunkt2D slutpunkt)
    {
        Startpunkt = startpunkt;
        Slutpunkt = slutpunkt;

    }

    public void UdskrivVektor()
    {
        double xKomposant = Slutpunkt.X - Startpunkt.X;
        double yKomposant = Slutpunkt.Y - Startpunkt.Y;

        Console.WriteLine(xKomposant+";"+yKomposant);
    }

    public double BeregnLængde()
    {
        double xKomposant = Slutpunkt.X - Startpunkt.X;
        double yKomposant = Slutpunkt.Y - Startpunkt.Y;

        return Math.Pow(Math.Pow(xKomposant,2) + Math.Pow(yKomposant,2), 0.5);
    }

    public double BeregnSkalarprodukt(IVektor2D vektor2)
    {
        double v1xKomposant = Slutpunkt.X - Startpunkt.X;
        double v1yKomposant = Slutpunkt.Y - Startpunkt.Y;
        double v2xKomposant = vektor2.Slutpunkt.X - vektor2.Startpunkt.X;
        double v2yKomposant = vektor2.Slutpunkt.Y - vektor2.Startpunkt.Y;
        
        return (v1xKomposant*v2xKomposant + v1yKomposant*v2yKomposant);
    }

    public Vektor2D BeregnTværvektor()
    {
        double xKomposant = Slutpunkt.X - Startpunkt.X;
        double yKomposant = Slutpunkt.Y - Startpunkt.X;

        Punkt2D tp = new Punkt2D(-(Slutpunkt.X+yKomposant), Slutpunkt.Y+xKomposant);

        return(new Vektor2D(Startpunkt,tp));
    }

    public IVektor2D BeregnVektorsum(IVektor2D vektor)
    {
        throw new System.NotImplementedException();
    }

    public double BeregnVinkelMedXAkse()
    {
        throw new System.NotImplementedException();
    }

    public bool ErOrtogonalMed(IVektor2D vektor)
    {
        throw new System.NotImplementedException();
    }

    public bool ErParallelMed(IVektor2D vektor)
    {
        throw new System.NotImplementedException();
    }
}