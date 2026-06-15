namespace Week10Hm1;

public class Calculator
{
    public int _num1 { get; set; }
    public int _num2 { get; set; }
    public int _num3 { get; set; }

    public  void Calculate(int x , int y)
    {
        Console.WriteLine(x + y);
    }
    public  void Calculate(int x ,int y , int z)
    {
        Console.WriteLine(x + y + z);
    }
    
}