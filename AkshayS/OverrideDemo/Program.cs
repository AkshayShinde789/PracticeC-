class program
{
    static void Main()
    {
        //Vihaash v = new Vihaash("Amay","Pande");
        //v.Problem();
        //Vihaash v1 = new VStudent("Sanay", "Bansali");
        //v1.Problem();
        VStudent s = new VStudent("Rahul", "Chandre");
        s.Problem();
        Console.ReadLine();
    }
}
class Vihaash
{
    public string FirstName;
    public string LastName;
    public Vihaash(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }

    public virtual void Problem()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName}");
    }
}
class VStudent : Vihaash
{
    public VStudent(string fn, string ln):base(fn,ln)
    { }
    public override void Problem()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName}--student");
    }
}