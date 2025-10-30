namespace stringclass;

class Program
{
    static void Main(string[] args)
    {
        string[] geenCaps = new string[] { "global", "variable", "class" };
        
        for (int i = 0; i < geenCaps.Length; i++)
        {
            Console.WriteLine($"{geenCaps[i]}");
            Console.WriteLine($"is een string die {geenCaps[i].Length} lang is");
            Console.WriteLine($"{geenCaps[i].ToUpper()}");
        }
    }
}
