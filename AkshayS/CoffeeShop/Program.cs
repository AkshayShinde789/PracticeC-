class program
{
    static void Main()
    {
        string order = "";
        int FinalAmount = 0;
        int SmallCoffeeTotal = 0;
        int MediumCoffeeTotal = 0;
        int LargeCoffeeTotal = 0;
        
        Console.WriteLine("Welcome to CoffeeShop");
        Console.WriteLine(" 1 - SMALLCOFFEE\t2 - MEDIUMCOFFEE\t3 - LARGECOFFEE");
        do
        {
            Console.WriteLine("Please Choose Coffee Size");
            string size = Console.ReadLine();

            switch (size.ToUpper())
            {
                case "SMALL":
                    Console.WriteLine("How many Small Coffee");
                    int sc = Convert.ToInt32(Console.ReadLine());
                    SmallCoffeeTotal += sc;
                    break;
                case "MEDIUM":
                    Console.WriteLine("How many Medium Coffee");
                    int mc = Convert.ToInt32(Console.ReadLine());
                    MediumCoffeeTotal += mc;
                    break;
                case "LARGE":
                    Console.WriteLine("How many Large Coffee");
                    int lc = Convert.ToInt32(Console.ReadLine());
                    LargeCoffeeTotal += lc;
                    break;
                default:
                    Console.WriteLine($"{size} is not available");
                    break;
            }
            Console.WriteLine("Do you want to Order Again");
            order = Console.ReadLine();
        } while (order == "yes" || order == "y");

        if(SmallCoffeeTotal > 0 || MediumCoffeeTotal > 0 || LargeCoffeeTotal > 0 )
        { 
        Console.WriteLine("********* Belling Section *********");
        }
        if (SmallCoffeeTotal > 0)
        {
            Console.WriteLine($"SmallCoffe {SmallCoffeeTotal} * 40 = {SmallCoffeeTotal * 40}");
            FinalAmount += SmallCoffeeTotal * 40;
        }
        if(MediumCoffeeTotal > 0)
        {
            Console.WriteLine($"MediumCoffee {MediumCoffeeTotal} * 60 = {MediumCoffeeTotal * 60}");
            FinalAmount += MediumCoffeeTotal * 60;
        }
        if(LargeCoffeeTotal > 0)
        {
            Console.WriteLine($"LargeCoffee {LargeCoffeeTotal} * 80 = {LargeCoffeeTotal * 80}");
            FinalAmount += LargeCoffeeTotal * 80;
        }

        if(SmallCoffeeTotal>0 || MediumCoffeeTotal > 0 || LargeCoffeeTotal > 0 )
        { 
        Console.WriteLine($"**********Final Receipt************");
        Console.WriteLine($"FinalBill : {FinalAmount}");
        }
        Console.WriteLine("Thank you visit again");
        Console.ReadLine();
    }
}