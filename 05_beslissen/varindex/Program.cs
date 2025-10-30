namespace varindex;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("mario = 0, sonic = 1, spyro = 2");
        string gekozen = Console.ReadLine();
        string[] VideoGameCaracterNamen = new string[] { "mario", "sonic", "spyro" };

        if (gekozen == "0") {

            Console.WriteLine("je koos 0");
            Console.WriteLine("mario");
        }

        else if (gekozen == "1") {
            Console.WriteLine("je koos 1");
            Console.WriteLine("sonic");
        }
                
                
            else if (gekozen == "2"){
            Console.WriteLine("je koos 2");
            Console.WriteLine("spyro");
        }
    }
}
