class program
{
    static void Main()
    {
        Student s = new Student();
        s.Print();
        Teacher t = new Teacher();t.Print();
        Student st = new Teacher();st.Print();
        Console.ReadLine();
    }
}
class Student
{
    public void Print()
    {
        Console.WriteLine("Print() method call");
    }
}
class Teacher : Student
{
    public new  void Print()
    {
        Console.WriteLine("Teacher Print() method call");
    }
}