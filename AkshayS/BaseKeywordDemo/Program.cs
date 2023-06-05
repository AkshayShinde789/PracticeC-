//class program
//{
//    static void Main()
//    {
//        Console.ReadLine();
//    }
//}
//class Company
//{
//    public string FirstName;
//    public string LastName;

//    public Company(string fn, string ln)
//    {
//      FirstName = fn;
//        LastName = ln;
//    }
//    public virtual void PrintFullName()
//    {
//        Console.WriteLine($"FullName : {FirstName} {LastName}");
//    }

//}

//// base keyword : point to base class using base keyword
//class Employee 
//{
//    public override void PrintFullName()
//    {
//        //Console.WriteLine($"FullName : {FirstName} {LastName} -- Employee");
//    }
//}


class program
{
    static void Main()
    {
      //  Person p1 = new Person("Santosh");
        //Employee e1 = new Employee();
       // Student s1 = new Student();
       // Person p2 = new Employee("Mishra");
      Person  p2 = new Employee("Ramesh", 21);

        Console.ReadLine();
    }
}
class Person
{
    public string Name = "Vaibhav";
    public string FirstName;
    public Person()
    {
        Console.WriteLine("public person()");
    }
    public Person(string fn)
    {
        Console.WriteLine("Person(string fn)");
    }
    public Person( int id)
    {
        Console.WriteLine($" Person( int id) = {id}");
    }
}
class Employee : Person
{
    public string Name = "Sanjay";
    //public Employee()
    //{
    //    Console.WriteLine("public Employee()");
    //    Console.WriteLine(base.Name);
    //}
    //public Employee(string fn) : base(10) // we can access the base class constructor using base(value) or
    //                                      // we also solve this error by declaring base class constructor as parameterless
    //{
    //    Console.WriteLine("Employee(string fn)");
    //}
    public Employee(string fn, int id) : base(id)
    {
        Console.WriteLine($"Employee(string fn, int id) {fn}");
    }
}
//class Student : Person
//{
//    public Student()
//    {
//        Console.WriteLine("public Student()");
//    }
//}