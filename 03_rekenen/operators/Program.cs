namespace operators;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int plus = 9;
        Console.WriteLine($"plus start op {plus}");
        plus++;
        Console.WriteLine($"plus is nu {plus}");
        plus--;
        Console.WriteLine($"plus is nu {plus}");
        plus--;
        Console.WriteLine($"plus is nu {plus}");
        plus += 3;
        plus -= 3;

        int voorbeeld1 = 20;
        voorbeeld1 += 10;
        Console.WriteLine($"voorbeeld1 is nu 30, zie: {voorbeeld1}");

        int voorbeeld2 = 20;
        int result = voorbeeld2 + 10;
        Console.WriteLine($"voorbeeld2 is nu 20, zie {voorbeeld2}, wie is wel 30?");

        int Waarde = 10;
        Console.WriteLine($"Waarde is :{Waarde}");
        Waarde -= 5;
        Console.WriteLine($"Waarde is nu :{Waarde}");

        double Getal = 2.5;
        Console.WriteLine($"Getal is :{Getal}");
        Getal *= 2;
        Console.WriteLine($"Getal is nu :{Getal}");

        float Ja2 = 5;
        Console.WriteLine($"Ja2 is :{Ja2}");
        Ja2 /= 2;
        Console.WriteLine($"Ja2 is nu :{Ja2}");
    }
}
