namespace Week10Hm1;

public  class Rectangle: Shape
{
    public override void getArea(int a , int b)
    {
        Console.WriteLine( $"This is area of rectangle: {a * b}");
    }
}