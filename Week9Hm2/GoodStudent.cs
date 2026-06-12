namespace Week9Hm2;

public class GoodStudent: Student1
{
    
    public override void Study()
    {
        Console.WriteLine($"Good student {_name} is studying hard!");
    }

    public override void Read()
    {
        Console.WriteLine($"Good student {_name} is reading carefully!");
    }

    public override void Write()
    {
        Console.WriteLine($"Good student {_name} is writing perfectly!");
    }

    public override void Relax()
    {
        Console.WriteLine($"Good student {_name} is relaxing a bit.");
    }
}