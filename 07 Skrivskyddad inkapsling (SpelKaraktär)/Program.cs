namespace _07_Skrivskyddad_inkapsling__SpelKaraktär_;

public class SpelKaraktär
{
    // Publik get men privat set gör att hälsan bara kan ändras inifrån klassen via metoder
    public int Hälsa { get; private set; }
    //public int Hälsa { get; }       // Utan set kan vi inte ändra på något vis, inte ens inifrån
    public SpelKaraktär()
    {
        Hälsa = 100;
    }

    public void TaSkada(int skada)
    {
        Hälsa = Math.Max(0, Hälsa - skada);
        if (Hälsa == 0)
        {
            Console.WriteLine("Karaktären har besegrats!");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 7: Inkapsling (Private Set) ---\n\n");

        SpelKaraktär heroine = new SpelKaraktär();

        //heroine.Hälsa = 1000;     // Privat SET gör detta omöjligt

        heroine.TaSkada(40);
        Console.WriteLine($"Aktuell hälsa: {heroine.Hälsa}");

        heroine.TaSkada(80); // Kommer att ta ner hälsan till noll
        Console.WriteLine($"Aktuell hälsa: {heroine.Hälsa}");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
