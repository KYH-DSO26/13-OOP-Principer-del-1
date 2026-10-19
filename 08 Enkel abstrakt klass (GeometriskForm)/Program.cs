namespace _08_Enkel_abstrakt_klass__GeometriskForm_;

// En abstrakt klass fungerar ENBART som en ritning och kan inte instansieras (new:as)
public abstract class GeometriskForm
{
    public string Färg { get; set; }

    // En abstrakt metod saknar kropp och MÅSTE implementeras av underklasser
    public abstract void Rita();
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 8: Abstrakta klasser ---\n\n");

        // AVKOMMENTERA FÖR ATT VISA ATT DET INTE GÅR:
        //GeometriskForm form = new GeometriskForm();     // Ger kompileringsfel


        Console.WriteLine("Abstrakta klasser kan inte instansieras med 'new'.");



        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
