namespace WEEK4HM1;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region ex1
        Console.WriteLine("Enter number: ");
        int number;
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Enter again!");
            }
            else
            {
                Console.WriteLine("Good job!");
                break;
            }
        }
        Console.WriteLine(number % 5 == 0 ? "Yes" : "No");
        #endregion
        */
        /*
        #region ex2

        Console.WriteLine("Enter number x: ");
        var x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number y: ");
        var y = int.Parse(Console.ReadLine());

        var s = x + y;
        var m = y > x ? y - x : x - y;
        var p = x * y;

        Console.WriteLine($"X + Y = {s}");
        Console.WriteLine($"X - Y = {m}");
        Console.WriteLine($"X * Y = {p}");
        int d = 0;
        if (x > y)
        {
            if (y == 0)
            {
                Console.WriteLine("Can't divide by zero!");
            }
            else
            {
                d = x / y;
            }
        }
        else if (y > x)
        {
            if (x == 0)
            {
                Console.WriteLine("Can't divide by zero");
            }
            else
            {
                d = y / x;
            }
        }
        else
        {
            d = 1;
        }
        
        
        Console.WriteLine(d !=0 ? $"X / Y = {d}" : "");

        #endregion
        */
        /*
        #region ex3
        Console.WriteLine("Enter x: ");
        var x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        var y = int.Parse(Console.ReadLine());
        Console.WriteLine($"X = {x}, Y ={y}");
        var temp1 = x;
        x = y;
        y = temp1;
        Console.WriteLine($"X = {x}, Y = {y}");
        #endregion
        */
        /* 
        #region ex4
        Console.WriteLine("Enter your number: ");
        var x = int.Parse(Console.ReadLine());
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine($"{x} * {i} = {x * i}");
        }
        #endregion
        */
        /*
        #region ex5
        Console.WriteLine("Enter your number: ");
        var n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i * i);
            }
        }
        #endregion
        */
    }
}