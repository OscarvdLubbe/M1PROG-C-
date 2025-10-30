namespace stappen;

class Program
{
    static void Main(string[] args)
    {
        float[] vectors = new float[]
        {
            6, 7, 8,
            1, 4, 0

        };
        for (int i = 0; i < vectors.Length; i++)
        {
            Console.WriteLine($"vector vanaf index 0: ({vectors[i++]}, {vectors[i++]}, {vectors[i++]})");
            Console.WriteLine($"vector vanaf index 3: ({vectors[i++]}, {vectors[i++]}, {vectors[i++]})");
        }
    }
}
