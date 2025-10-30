using System.Runtime.CompilerServices;

namespace math;

class Program
{
    static void Main(string[] args)
    {
        double kleiner = 9;
        double groter = 19;

        double kleine = 9;
        double grote = 14;

        double getal = 16;
        double min = 20;
        double max = 30;

        double sqrtGetal = 16;

        double welkeIsKleiner = Math.Min(kleiner, groter);
        Console.WriteLine($"{welkeIsKleiner} Is de kleinste van {kleiner} en {groter}");

        double welkeIsGroter = Math.Max(kleine, grote);
        Console.WriteLine($"{welkeIsGroter} Is de grootste van {kleine} en {grote}");

        double ClampGebreuken = Math.Clamp(getal, min, max);
        Console.WriteLine($"Het clamp resultaat van {getal} met min {min} en max {max} is de {ClampGebreuken}");

        double sqrtNummer = Math.Sqrt(sqrtGetal);
        Console.WriteLine($"De sqrt van {sqrtGetal} is de {sqrtNummer}");
    }
}
