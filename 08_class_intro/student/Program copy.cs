namespace student;

class Program
{
    
    static void Main(string[] args)
    {
        student student0 = new student();

        student0.name = "bart simpson";
        student0.leeftijd = 14;
        student0.studentenNummer = 24685;

        student student1 = new student();

        student1.name = "lisa simpson";
        student1.leeftijd = 13;
        student1.studentenNummer = 65465;

        Console.WriteLine("Student: " + student0.name);
        Console.WriteLine("leeftijd: " + student0.leeftijd);
        Console.WriteLine("studentenNummer: " + student0.studentenNummer);

        Console.WriteLine("Student: " + student1.name);
        Console.WriteLine("leeftijd: " + student1.leeftijd);
        Console.WriteLine("studentenNummer: " + student1.studentenNummer);

        student0.ToonNaam();
        student1.ToonNaam();

        student0.ToonLeeftijd();
        student1.ToonLeeftijd();
    }
}
