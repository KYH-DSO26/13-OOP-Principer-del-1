namespace _14_Smartklocka__Kombinera_flera_gränssnitt_;

public interface ILaddbar { void Ladda(); }

public interface IGps
{
    void HämtaPosition();
}


// C# Tillåter inte arv från flera klasser. Däremot kan man implementera många interface
public class SmartKlocka : ILaddbar, IGps
{
    public void HämtaPosition()
    {
        Console.WriteLine("Lat: 59.3293, Lon: 18.0686");
    }

    public void Ladda()
    {
        Console.WriteLine("Klockan laddas induktivt.");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 14: Flera gränssnitt ---\n\n");

        SmartKlocka iWatch = new SmartKlocka();
        iWatch.Ladda();
        iWatch.HämtaPosition();





        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
