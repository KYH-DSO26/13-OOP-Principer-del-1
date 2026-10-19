namespace _09_Implementera_en_abstrakt_klass__Cirkel_;

public abstract class GeometriskForm
{
    public string Färg { get; set; }

    // En abstrakt metod saknar kropp och MÅSTE implementeras av underklasser
    public abstract void Rita();
}

// Concrete class som ärver och implementerar det abstrakta kontraktet
public class Cirkel : GeometriskForm
{
    public override void Rita()
    {
        Console.WriteLine($"Systemet ritar en fin {Färg} cirkel.");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 9: Override av metoder ---\n\n");

        Cirkel c = new Cirkel();
        c.Färg = "Röd";
        c.Rita();






        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
