namespace _11_Skapa_ett_enkelt_gränssnitt__ILaddbar_;


// Ett gränssnitt innehåller inga variabler eller färdig kod, bara krav på metoder
public interface ILaddbar
{
    void Ladda();
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 11: Interfaces (Gränssnitt) ---\n\n");
        
        //var telefon = new ILaddbar();     // Gränssnitt kan inte instansieras!

        Console.WriteLine("Interface definierat. Inga metoder har kodkropp i ett interface.");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
