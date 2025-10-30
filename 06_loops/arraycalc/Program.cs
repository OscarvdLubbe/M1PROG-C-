namespace arraycalc;

class Program
{
    static void Main(string[] args)
    {
        double[] saldos = new double[] { 240.99, 1142.23, 789.89, 658.72 };
        
        for(int i =0; i< saldos.Length; i++)
        {
            Console.WriteLine($"salsa: {saldos[i]}");
            Console.WriteLine($"salsa na verhoging: {saldos[i] + 100}");
        }
    }
}
