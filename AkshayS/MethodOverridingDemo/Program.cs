/*using System;

class program
{
    static void Main()
    {
        //Person p = new Person("Ashish","Sathe");
        //p.PrintFullName();
        //p = new Employee("Suraj","Kumbhalkar");
        //p.PrintFullName();
        Person[] p = new Person[5];
        p[0] = new Person("Anil", "Shirbhate");
        p[1] = new Person("Sham", "Gubre");
        p[2] = new Person("Rajesh", "Dighe");
        p[3] = new Person("Govind", "Nakhate");
        p[4] = new Person("Sonu", "Lohat");

        Person p1 = new Employee("Rahul","Rathod");
        Person p2 = new Student("Sanjay", "Mishra");
        Employee e = new Student("Sonali", "Kulkarni");
        p1.PrintFullName();
        p2.PrintFullName();


        for(int i = 0; i < p.Length; i++)
        {
            p[i].PrintFullName();
        }


        Console.ReadLine();
    }
}
class Person
{
    public string FirstName;
    public string LastName;
    public Person(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }
    public virtual void PrintFullName()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName}");
    }
}
class Employee : Person
{
    public Employee(string fn, string ln) : base(fn, ln)
    {

    }
    public override void PrintFullName()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} -- Employee");
    }
}
class Student : Employee
{
    public Student(string fn, string ln) : base(fn, ln)
    {

    }
    public override void PrintFullName()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} -- Student");
    }
}
class Teacher : Person
{
    public Teacher(string fn, string ln) : base(fn, ln)
    {

    }
    public override void PrintFullName()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} -- Teacher");
    }
}
class Celibrity : Person
{
    public Celibrity(string fn, string ln) : base(fn, ln)
    {

    }
    public override void PrintFullName() // if we are not overrided any method then they calls base class method
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} -- Celebrity");
    }
}*/

class program
{
    static void Main()
    {
        VihaashTeam v = new VihaashTeam("Ramesh", "Ruikar", "Ganesh");
        v.Problem();
        Student s = new Student("Gaurav","Kale","Rushikesh");
        s.Problem();
        SeniorStudent ss = new SeniorStudent("Santosh", "Pawar", "Sachin");
        ss.Problem();
        WorkingStudent ws = new WorkingStudent("Suraj", "Kumbhalkar", "Shrikant");
        ws.Problem();

        VihaashTeam vs = new Student("Rajesh", "Mude", "Mahendra");
        vs.Problem();
        VihaashTeam vss = new SeniorStudent("Kantamma", "Sardar", "Shamli");
        vss.Problem();

        Console.ReadLine();
    }
}
class VihaashTeam
{
    public string FirstName;
    public string LastName;
    public string ReferenceName;
    public VihaashTeam(string fn, string ln, string rn)
    {
        FirstName = fn;
        LastName = ln;
        ReferenceName = rn;
        Console.WriteLine("VihaashTeam(string fn, string ln, string rn)");
    }
    public virtual void Problem()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} ReferenceName : {ReferenceName} ");
    }
}
class Student : VihaashTeam
{
    public Student(string fn, string ln, string rn) : base(fn, ln, rn) {
        Console.WriteLine("Student(string fn, string ln, string rn) : base(fn, ln, rn)");
    }

    public override void Problem()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} ReferenceName : {ReferenceName} -- Syllabus Problem  ");
    }
}
class SeniorStudent : VihaashTeam
{
    public SeniorStudent(string fn, string ln, string rn) : base(fn, ln, rn) {
        Console.WriteLine("SeniorStudent(string fn, string ln, string rn) : base(fn, ln, rn)"); 
    }
    public override void Problem()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} ReferenceName : {ReferenceName}-- Interview Problem");
    }
}
class WorkingStudent :  VihaashTeam
{
    public WorkingStudent(string fn, string ln, string rn) : base(fn, ln, rn) {
        Console.WriteLine("WorkingStudent(string fn, string ln, string rn) : base(fn, ln, rn)");

    }

    public override void Problem()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} ReferenceName : {ReferenceName}-- Task Regarding Problem");
    }
}