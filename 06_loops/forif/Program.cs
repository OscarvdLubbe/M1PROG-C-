namespace forif;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 2; i <= 6; i++)
        {
            Console.WriteLine($"{nummers[i]}");
        }
    }
}