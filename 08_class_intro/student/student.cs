namespace student;

class student
{
    internal string name;
    internal int leeftijd;
    internal int studentenNummer;

    public void ToonNaam()
    {
        Console.WriteLine("Naam: " + name);
    }
    public void ToonLeeftijd()
    {
        Console.WriteLine("leeftijd: " + leeftijd);
    }
}