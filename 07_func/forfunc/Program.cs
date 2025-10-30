namespace forfunc;

class Program
{
    static void Main(string[] args)
    {
        double[] basis = new double[] {2, 5, 78, 98};

        for (int i = 0; i < basis.Length; i++)
        {
            double Answer = Math.Pow(basis[i], 2);
            Console.WriteLine($"{basis[i]} keer zichzelf {Answer}");
        }
    }
}
