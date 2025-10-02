namespace of;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kies een fruit: 1 = appel, 2 = banaan, 3 = citroen, 4 = guava, 5 = mango");
        int keuze = int.Parse(Console.ReadLine());
        int appel = 1;
        int banaan = 2;
        int citroen = 3;
        int guava = 4;
        int mango = 5;
        if (keuze == appel || keuze == banaan || keuze == mango)
            Console.WriteLine("Yum Yum");
        else if (keuze == citroen || keuze == guava)
            Console.WriteLine("Yuck");
    }
}
