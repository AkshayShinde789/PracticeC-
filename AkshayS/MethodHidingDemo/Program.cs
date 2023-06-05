class program
{
    static void Main()
    {
        //   Person p1 = new Person();
        //  p1.Greet();
        //Employee e = new Employee();
        //e.Greet();
        //Person p2 = new Employee();
        //p2.Greet();
        //Student s = new Student();
        //s.Greet();
        //Person p3 = new Student();
        //p3.Greet();

        //Teacher t = new Teacher("Sanjay", "Kathode");
        //t.PrintFullName();

        ClassRoom c = new ClassRoom("Sumit","Katkar");
        //c.PrintFullName();

        //Teacher t1 = new ClassRoom("Sushil", "Rathod");
        //t1.PrintFullName();

        //Teacher t3 = new ShowRoom("swift", "Desire");
        //t3.PrintFullName();

        Console.ReadLine();
    }
}

class Person
{
    public virtual void Greet()
    {
        Console.WriteLine("I am a person!");
    }
}

class Employee : Person
{
    public override void Greet()
    {
        Console.WriteLine("I am the Manager!");
    }
}
class Student : Person
{
    public new  void Greet()
    {
        Console.WriteLine("I am Student");
    }
}
class Teacher
{
    public string firstname;
    public string lastname;
    public Teacher(string fn, string ln)
    {
        firstname = fn;
        lastname = ln;
        Console.WriteLine("Teacher(string fn, string ln)");
    }
    //public void PrintFullName()
    //{
    //    Console.WriteLine($"FullName : {firstname} {lastname}");
    //}
}
class ClassRoom : Teacher
{
    public ClassRoom(string fn, string ln) : base(fn, ln)
    {
        Console.WriteLine("ClassRoom(string fn, string ln)");
    }
    //public  void PrintFullName()
    //{
    //    Console.WriteLine($"FullName : {firstname} {lastname} --classroom");
    //}
}
class ShowRoom : Teacher
{
    public ShowRoom(string fn, string ln) : base(fn, ln)
    { }
    public  void PrintFullName()
    {
        Console.WriteLine($"FullName : {firstname} {lastname} --Showroom");
    }
}
