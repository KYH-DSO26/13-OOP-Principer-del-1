namespace _12_Implementera_ett_gränssnitt__Mobiltelefon_;


// Ett gränssnitt innehåller inga variabler eller färdig kod, bara krav på metoder
public interface ILaddbar
{
    void Ladda();
}

// Mobiltelefon förbinder sig att följa kontraktet ILaddbar
public class Mobiltelefon : ILaddbar
{
    public void Ladda()
    {
        Console.WriteLine("Mobiltelefonen laddas via USB-C...");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 12: Implementera Interface ---\n\n");

        Mobiltelefon tfn = new Mobiltelefon();
        tfn.Ladda();



        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
