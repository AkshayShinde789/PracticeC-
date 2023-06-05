class program
{
    static void Main()
    {
        int v1 = 10;
        int v2 = 20;
        int v3 = 30;

        bool b1 = v1 == v2;
        Console.WriteLine(b1);
        b1 = v1 != v2;
        Console.WriteLine(b1);
        b1 = v1 > v2;
        Console.WriteLine(b1);
        b1 = v2 > v1;
        Console.WriteLine(b1);

        b1 = v1 < v2 && v2 < v3;
        Console.WriteLine(b1);

        b1 = v1 > v2 || v1 < v3;
        Console.WriteLine(b1);

        b1 = v3 == v1 && v2 > v3;
        Console.WriteLine(b1);

        b1 = v2 == v1 || v2 < v3 && v1 > v2 || v1 < v2 && v2 >v3 || v1 >v2;
        Console.WriteLine(b1);


        Console.WriteLine("Please enter a name ");
        string name = Console.ReadLine().ToUpper();

        string name2 = "MAHESH";
        //b1 = name == name2;

        if (name == name2)
        {
            Console.WriteLine($"You enter name correctly");
        }
        else
        {
            Console.WriteLine($"You enter incorrect name");
        }
        int a = 10;int sum = 10;
        sum += a;
        Console.WriteLine(sum);

        string path = @"C:\pc\Turbo.C.3.2\WinRoot\TURBOC3\Projects";
        Console.WriteLine(path);

        int i = 25;       
        Console.WriteLine(Math.Sqrt(i));

        Console.ReadLine();
    }
}