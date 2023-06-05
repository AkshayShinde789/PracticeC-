class Program
{
    static void Main()
    {
        ClassTeacher ct = new ClassTeacher(5, "Marathi");
        ct.Teacher(12, "English");
        ClassStudent cs = new ClassStudent(10, "Math");
        cs.Student(13, "Algebra");
        ClassTeacher ct1 = new ClassStudent(4, "Hindi");
        ct1.Teacher(15, "Geomitry");
        Console.ReadLine();
    }
}
class ClassTeacher
{
    public int Std;
    public string Subject;
    public ClassTeacher( int standard, string Sub)
    {
        Std = standard;
        Subject = Sub;
        Console.WriteLine($"{Std} {Subject}");
    }
    public void Teacher(int standard, string sub)
    {
        Console.WriteLine($"Teacher is teaching {standard} {sub}");
    }
}
class ClassStudent : ClassTeacher
{
    public ClassStudent( int standard, string Sub) : base(standard,Sub)
    {
        Console.WriteLine($"{Std} {Subject} -- StudentSection--");
    }
    public void Student(int standard, string sub)
    {
        Console.WriteLine($"Student is Learining {standard} {sub}");
    }
}