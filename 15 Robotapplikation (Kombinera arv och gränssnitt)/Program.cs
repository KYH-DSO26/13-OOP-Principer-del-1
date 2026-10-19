namespace _15_Robotapplikation__Kombinera_arv_och_gränssnitt_;

public abstract class Maskin
{
    public string Serienummer { get; set; }
    public abstract void SkrivUtSerienummer();
    
}

public interface ILaddbar
{
    void Ladda();
}


// Regel: Basklassen (den vi ska ÄRVA) måste ALLTID komma först
// Sedan kommer gränssnitten, separerade med kommatecken
public class Robot : Maskin, ILaddbar
{
    public override void SkrivUtSerienummer()
    {
        Console.WriteLine($"Serienummer: {Serienummer}");
    }

    public void Ladda()
    {
        Console.WriteLine($"Robot med serienummer {Serienummer} laddar sina litiumbatterier.");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 15: Kombinera arv och gränssnitt ---\n\n");

        Robot robot = new Robot();
        robot.Serienummer = "BOT-X-2000";
        robot.Ladda();
        robot.SkrivUtSerienummer();

 





        Console.Write("\n\nTryck på en tangent för att stänga fönstret");
        Console.ReadKey();
    }
}
