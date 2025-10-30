namespace bruto;

class Program
{
    static void Main(string[] args)
    {
        double[] brutoSalarissen = new double[] { 30000,60000,80000};
        double[] nettoSalarissen = new double[3] { 0.0, 0.0, 0.0};
        nettoSalarissen[0] = brutoSalarissen[0] * (1 - 0.3582);
        //brutoSalarissen[0] * 1.3582;

        nettoSalarissen[1] = brutoSalarissen[1] * (1 - 0.3748);
        //brutoSalarissen[1] * 1.3582;

        nettoSalarissen[2] = brutoSalarissen[2] * (1 - 0.4950);
        //brutoSalarissen[2] * 1.3582;

        Console.WriteLine($"persoon 1 houdt {nettoSalarissen[0]} netto over van {brutoSalarissen[0]} bruto");
        Console.WriteLine($"persoon 2 houdt {nettoSalarissen[1]} netto over van {brutoSalarissen[1]} bruto");
        Console.WriteLine($"persoon 3 houdt {nettoSalarissen[2]} netto over van {brutoSalarissen[2]} bruto");
        
    }
}
