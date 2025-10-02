namespace en;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Staat de deur voor je? (yes/no)");
        bool doorNeedKey = Console.ReadLine() == "yes";
        Console.WriteLine("Heb je een sleutel? (yes/no)");
        bool hasKey = Console.ReadLine() == "yes";
        if (doorNeedKey && hasKey == false)
        {
            Console.WriteLine("Je hebt geen sleutel om de deur te openen.");
        }
        else if (doorNeedKey == false && hasKey == false)
        {
            Console.WriteLine("Je staat niet voor een deur en je hebt geen sleutel");
        }
        else if (doorNeedKey == false && hasKey)
        {
            Console.WriteLine("Je hebt de sleutel van de deur waar je niet staat.");
        }
        else if (doorNeedKey && hasKey)
        {
            Console.WriteLine("Je kunt de deur openen.");
        }
    }
}
