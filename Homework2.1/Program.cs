namespace Homework2._1;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Giorgi sichinava");
        Console.ResetColor();
        
        Console.WriteLine("Enter something: ");
        var info = Console.ReadLine();
        Console.WriteLine($"This is user input: {info}");
        


    }
}