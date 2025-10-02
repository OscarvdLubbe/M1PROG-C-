namespace of;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kies een fruit: 0 = appel, 1 = banaan, 2 = citroen");
        int keuze = int.Parse(Console.ReadLine());
        int appel = 0;
        int banaan = 1;
        int citroen = 2;
        if (keuze == appel || keuze == banaan)
            Console.WriteLine("Yum Yum");
        else if (keuze == citroen)
            Console.WriteLine("Yuck");
    }
}
