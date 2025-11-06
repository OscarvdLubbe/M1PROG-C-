namespace autoclass;

class Program
{
    static void Main(string[] args)
    {
        Auto mijnAuto1 = new Auto();

        mijnAuto1.bouwjaar = 2010;
        mijnAuto1.merk = ("BMW");

        Console.WriteLine(mijnAuto1);
        Console.WriteLine("Auto merk: " + mijnAuto1.merk);
        Console.WriteLine("Auto bouwjaar: " + mijnAuto1.bouwjaar);
        
        Auto mijnAuto2 = new Auto();

        mijnAuto2.bouwjaar = 2015;
        mijnAuto2.merk = ("volkswagen");

        Console.WriteLine("tweede auto");
        Console.WriteLine("Auto merk: " + mijnAuto2.merk);
        Console.WriteLine("Auto bouwjaar: "+ mijnAuto2.bouwjaar);
    }
}
