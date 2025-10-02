namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Heb je de sleutel gevonden?(y/n)");
        bool sleutelKwijt = Console.ReadLine() == "n";
        if (sleutelKwijt == true)
        {
            Console.WriteLine("Je bent de sleutel kwijt");
            Console.WriteLine("De deur kan niet open");

        }
        else
        {
            Console.WriteLine("Je kunt de deur open doen, want je hebt de sleutel.");
            Console.WriteLine("Je hebt de sleutel");
            Console.WriteLine("Je kan de deur openen");
            Console.WriteLine("Je kan naar binnen gaan");
        }
    }
}
