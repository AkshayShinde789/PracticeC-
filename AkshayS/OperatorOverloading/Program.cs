#region Operator
/*class program
{
    static void Main()
    {
        //int a = 10;
        //int b = a;
        //if(a == b)
        //{
        //    Console.WriteLine($"{a} & {b} are equal");
        //}
        //else
        //{
        //    Console.WriteLine($"{a} & {b} are not equal");
        //}
        Student s = new Student("Vaibhav","Jadhao");
        Student s1 = s; // check reference not value equality

        if(s1 == s)
        {
            Console.WriteLine($"{s} {s1} are Equal");
        }
        else
        {
            Console.WriteLine($"{s} {s1} not Equal");

        }
        Student s2 = new Student("Ramesh","Kale");
        s2.Print();
        Student s3 = new Student("Ramesh","Kale");
        s3.Print();
        s2.FirstName = s3.FirstName;
        s2.LastName = s3.LastName;
        if (s2 == s3)
        {
           
            Console.WriteLine($"{s2} {s3} are Equal");
        }
        else
        {
            Console.WriteLine($"{s2} {s3} not Equal");
        }
        Console.ReadLine();
    }
}
class Student
{
    public string FirstName;
    public string LastName;
    public Student(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }
    public void Print()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName}");
    }
}*/


/*class program
{
    static void Main()
    {
       // Student s = new Student("Suraj","Bansod");
       //Student s1 = s;
       // Student s2 = new Student("Suraj", "Ruikar");
       // s1 = s2;
       // s.FirstName = s2.FirstName;
       // s.LastName= s2.LastName;
        
        Console.ReadLine();
    }
}*/
//class Student
//{
//    public string FirstName;
//    public string LastName;
//    public Student()
//    {
//       // FirstName = fn;
//       // LastName = ln;
//        Console.WriteLine($"FullName : {FirstName} {LastName}");
//    }
//}
#endregion operator


class program
{
    static void Main()
    {
        Student s = new Student("Anil", "Chavhan");
        //Student s1 = s; // checks for reference equality not value equality
        Student s1 = new Student("Anil", "Rathod");// in complex type eqaul to operator checks value equality not reference equality
        if (s == s1) 
        {
            Console.WriteLine($"s & s1 are equal");
        }
        else
        {
            Console.WriteLine($"s & s1 are not equal");
        }
        Student s2 = s + s1;
        Console.WriteLine($"{s2.fn}, {s2.ln}");
        Console.ReadLine();
    }
}
class Student
{
    public string fn;
    public string ln;
    public Student(string f, string l)
    {
        fn = f;
        ln = l;
    }
    public static bool operator ==(Student s, Student s1)
    {
        return s.fn == s1.fn &&
        s.ln == s1.ln;
    }
    public static bool operator !=(Student s, Student s1)
    {
        return s.fn != s1.fn &&
            s.ln != s1.ln;
    }
    public static Student operator +(Student s, Student s1)
    {
        Student s2 = new Student(
            s.fn + " " + s1.fn,
            s.ln + " " + s1.ln
            );
        return s2;
    }
}