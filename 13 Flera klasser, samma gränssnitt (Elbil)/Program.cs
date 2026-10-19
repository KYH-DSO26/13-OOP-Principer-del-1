namespace _13_Flera_klasser__samma_gränssnitt__Elbil_;


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
public class Elbil : ILaddbar
{
    public void Ladda()
    {
        Console.WriteLine("Elbilen är kopplad till laddstolpen.");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 13: Samma kontrakt på olika klasser ---\n\n");

        Mobiltelefon tfn = new Mobiltelefon();
        tfn.Ladda();

        Elbil bil = new Elbil();
        bil.Ladda();





        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
