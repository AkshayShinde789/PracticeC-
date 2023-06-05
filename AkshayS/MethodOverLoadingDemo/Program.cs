class program
{
    static void Main()
    {
       Operation o = new Operation();
        o.Add(10);
        o.Add("Suraj");
        o.Add(30, 40);
        o.Add(50, 60, 70);
        o.Add(12, (float)12.45);
        o.Add((float)12.45, 12);
        o.Add((float)13.23, (float)21.34);
        o.Add(10,20);
        o.Add(20,30);
        o.Add(50);
        Console.ReadLine();
    }
   

}
class Operation
{
    public void Add(int a)
    {
        Console.WriteLine(a);
    }
    //public int Add(int a) // we cannot overload this method because of return type
    //{
    //    Console.WriteLine(a);
    //}
    
    public void Add(string a) //type of Parameter
    {
        Console.WriteLine(a);
    }
    //public void Add(int a, int b)
    //{
    //    Console.WriteLine(a + b);
    //}
    public void Add(int a, int b, int c) //Numbers of Parameter
    {
        Console.WriteLine(a + b + c);
    }
    public void Add(int a, float b) // order of parameter
    {
        Console.WriteLine(a + b);
    }
    public void Add(float a, int b) // order of parameter
    {
        Console.WriteLine(a + b);
    }

    public void Add(float a, float b)
    {
        Console.WriteLine(a + b);
    }

    public void Add(out int a) // Kinds of Parameter
    {
        a = 100;
        Console.WriteLine(a);
    }
    //public void Add(ref int a) // we cannot overload method on basis of ref and out keyword
    //{                          // in same class we cannot defined method with same name and same parameter as ref and out
    //    Console.WriteLine(a);
    //}
    public void  Add(params int[] a)
    {
        Console.WriteLine(a);
    }
    //public void Add(int[] a) // cannot overload method on basis or params
                               // only one allow in overloading either params or array
    //{
    //    Console.WriteLine(a);
    //}
    public void Add(short a, short b)
    {
        Console.WriteLine("Add(short a, short b)");
    }
    public void Add(int a, int b) // by default compiler print int values
    {
        Console.WriteLine("Add(int a, int b)");
        Console.WriteLine(a + b);
    }
    public void Add(ref int a, out int b)
    {
        b = 10;
        Console.WriteLine(a + b);
    }
}
class Teacher
{
    public string FirstName;
    public string LastName;
    public Teacher(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }
}
