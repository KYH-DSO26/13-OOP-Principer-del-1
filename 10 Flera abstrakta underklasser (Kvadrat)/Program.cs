namespace _10_Flera_abstrakta_underklasser__Kvadrat_;

public abstract class GeometriskForm
{
    public string Färg { get; set; }
    public double Sida { get; set; }

    // En abstrakt metod saknar kropp och MÅSTE implementeras av underklasser
    public abstract void Rita();

    public abstract double Area();
}

// Concrete class som ärver och implementerar det abstrakta kontraktet
public class Cirkel : GeometriskForm
{
    public override void Rita()
    {
        Console.WriteLine($"Systemet ritar en fin {Färg} cirkel.");
    }
    public override double Area()
    {
        double area;
        area = Math.PI * Sida * Sida;
        return area;
    }
}

public class Kvadrat : GeometriskForm
{
    public override void Rita()
    {
        Console.WriteLine($"Nu ritar en fin {Färg} kvadrat.");
    }

    public override double Area()
    {
        double area;
        area = Sida * Sida;
        return area;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 10: Flera underklasser ---\n\n");

        Cirkel c = new Cirkel();
        c.Sida = 1;
        c.Färg = "Röd";
        c.Rita();
        Console.WriteLine($"Arean: {c.Area():F3}");

        Kvadrat kv = new Kvadrat();
        kv.Sida = 2;
        kv.Färg = "Blå";
        kv.Rita();
        Console.WriteLine($"Arean: {kv.Area():F3}");






        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
