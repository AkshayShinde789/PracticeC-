class program
{
    static void Main()
    {
        Operation o = new Operation();
        o.Add(12, 12.45f);
        o.Add(12.45f, 12);
        o.Add(13.23f, 21.34f);
        Console.ReadLine();
    }
}
class Operation
{

    public void Add(int a, float b) // type of parameter
    {
        Console.WriteLine(a + b);
    }
    public void Add(float a, int b)
    {
        Console.WriteLine(a + b);
    }

    public void Add(float a, float b)
    {
        Console.WriteLine(a + b);
    }
}
