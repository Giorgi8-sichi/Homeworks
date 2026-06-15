namespace Week10Hm1;

public  class Triangle: Shape
{
    public override void getArea(int a, int b)
    {
        Console.WriteLine($"This is area of triangle: {a * b / 2}");
    }
}