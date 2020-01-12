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

        Console.WriteLine("Vektorens komposanter: " + xKomposant+";"+yKomposant);
    }

    public void UdskrivPunkter()
    {
        double p1x = Startpunkt.X;
        double p1y = Startpunkt.Y;
        double p2x = Slutpunkt.X;
        double p2y = Slutpunkt.Y;

        Console.WriteLine("Vektorens begyndelsespunkt: ("+p1x+","+p1y+")");
        Console.WriteLine("Vektorens slutpunkt: ("+p2x+","+p2y+")");

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
        double yKomposant = Slutpunkt.Y - Startpunkt.Y;

        Punkt2D tp = new Punkt2D(-yKomposant + Startpunkt.X, xKomposant+Startpunkt.Y);

        return(new Vektor2D(Startpunkt,tp));
    }

    public Vektor2D BeregnVektorsum(IVektor2D vektor)
    {
        double xAddKomposant = vektor.Slutpunkt.X - vektor.Startpunkt.X;
        double yAddKomposant = vektor.Slutpunkt.Y - vektor.Startpunkt.Y;

        Punkt2D tp = new Punkt2D(Slutpunkt.X + xAddKomposant, Slutpunkt.Y + yAddKomposant);
        return(new Vektor2D(Startpunkt,tp));
    }

    public Vektor2D BeregnVektordifferens(IVektor2D vektor)
    {
        double xAddKomposant = vektor.Slutpunkt.X - vektor.Startpunkt.X;
        double yAddKomposant = vektor.Slutpunkt.Y - vektor.Startpunkt.Y;

        Punkt2D tp = new Punkt2D(Slutpunkt.X - xAddKomposant, Slutpunkt.Y - yAddKomposant);
        return(new Vektor2D(Startpunkt,tp));
    }

    public double BeregnVinkelMedXAkse()
    {
        double xKomposant = Slutpunkt.X - Startpunkt.X;
        double yKomposant = Slutpunkt.Y - Startpunkt.Y;

        double v = Math.Atan((yKomposant/xKomposant)) * 180/Math.PI;

        if (xKomposant > 0 && yKomposant > 0){
            return(v);
        } 
        else if (xKomposant < 0 && yKomposant > 0){
            return(v+180);
        }
        else if (xKomposant < 0 && yKomposant < 0){
            return(v+180);
        }
        else if (xKomposant > 0 && yKomposant < 0){
            return(v+360);
        }
        else if (xKomposant == 0 && yKomposant > 0)
            return(90);
        else if (xKomposant == 0 && yKomposant < 0)
            return(270);
        else if (xKomposant > 0 && yKomposant == 0)
            return(0);
        else
            return(180);
    }

    public bool ErOrtogonalMed(IVektor2D vektor1, IVektor2D vektor2)
    {
        if (vektor1.BeregnSkalarprodukt(vektor2)==0){
            return(true);
        }
        else
            return(false);
    }

    public bool ErParallelMed(IVektor2D vektor1, IVektor2D vektor2)
    {
        
        Vektor2D tvektor1 = vektor1.BeregnTværvektor();

        if (tvektor1.BeregnSkalarprodukt(vektor2)==0){
            return(true);
        }
        else
            return(false);
    }
}