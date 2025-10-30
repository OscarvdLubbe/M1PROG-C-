namespace alsdan;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Is player moving? (yes/no)");
        string moving = Console.ReadLine();
        Console.WriteLine("Is player jumping? (yes/no)");
        string jumping = Console.ReadLine();
        
        if (moving == "yes" && jumping == "yes")
        {
            Console.WriteLine("player is jumping forward.");
        }
        else if (moving == "yes")
        {
            Console.WriteLine("player is moving.");
        }
        else if (jumping == "yes")
        {
            Console.WriteLine("player is jumping up.");
        }
        else
        {
            Console.WriteLine("player is idle.");
        }
    }
}
