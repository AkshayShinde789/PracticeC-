/*using System.ComponentModel;

class program
{
    static void Main()
    {
        int x = 10; int y = 2;
        int add, sub, div, mul, mod;
        Calculator(10, 20, out add, out sub, out mul, out div, out mod);
        Console.WriteLine($"Addition : {add}");
        Console.WriteLine($"Substraction : {sub}");
        Console.WriteLine($"Multiplication : {mul}");
        Console.WriteLine($"Division : {div}");
        Console.WriteLine($"Remainder : {mod}");
        Console.ReadLine();
    }
    public static void Calculator(int x, int y, out int add, out int sub, out int mul, out int div, out int mod)
    {

        add = x + y;
        sub = y - x;
        mul = x * y;
        div = y / x;
        mod = y % x;
    }
}*/


class program
{
    static void Main()
    {
        Console.WriteLine("please enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isprime = true;

        for(int i = 2; i < num; i++)
        {
            if(num % i == 0)
            {
                isprime = false;
                break;
            }
/*            else
            {
                isprime = true;
            }*/
        }
        if (isprime)
        {
            Console.WriteLine($"{num} is prime number");
        }
        else
        {
            Console.WriteLine($"{num} is not prime number");
        }

        Console.ReadLine();
    }
}