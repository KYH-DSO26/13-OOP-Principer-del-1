namespace _06_Inkapsling_med_validering__AnvändarProfil_;

public class AnvändarProfil
{
    private string _lösenord;
    public string Lösenord
    {
        get { return "********";  }     // Döljer det riktiga lösenordet vid utskrift
        set
        {
            if (value.Length >= 6)
            {
                _lösenord = value;
                Console.WriteLine($"Lösenordet uppdaterat.");
            }
            else
            {
                Console.WriteLine("FEL: Lösenordet måste vara minst 6 tecken!");
            }
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 6: Inkapsling (Lösenord) ---\n\n");

        var profil = new AnvändarProfil();
        profil.Lösenord = "123";            // För kort!
        profil.Lösenord = "jättehemligt";   // Godkänt

        Console.WriteLine($"Visning av lösenord: {profil.Lösenord}");   // Testar vår getter




        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
