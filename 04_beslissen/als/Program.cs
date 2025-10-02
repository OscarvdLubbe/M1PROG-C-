namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Je zoekt een sleutel");
        bool sleutelKwijt = true;
        if (sleutelKwijt == false)
        {
            Console.WriteLine("Je kunt de deur open doen, want je hebt de sleutel.");
            Console.WriteLine("Je hebt de sleutel");
            Console.WriteLine("Je kan de deur openen");
        }
        else
        {
            Console.WriteLine("Je bent de sleutel kwijt");
            Console.WriteLine("De deur kan niet open");
        }
    }
}
