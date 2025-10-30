static void Main(string[] args)
    {
        SayHelloWorld();
        //SayHelloWorld();
        //SayHelloWorld();
    }

    static void SayHelloWorld()
    {
        Console.WriteLine("Hello World");
        AfterIntro();
    }
    static void StopApp()
    {
        Console.WriteLine("Thank you, the app wil close now");
    }
    static void AfterIntro()
    {
        Console.WriteLine("Would you like to see the intro again? (y/n)");
        string Choice = Console.ReadLine();
        if (Choice == "y")
        {
            RestartApp();
        }
        else if (Choice == "n")
        {
            StopApp();
        }
    }
    static void RestartApp()
    {
        SayHelloWorld();
    }
