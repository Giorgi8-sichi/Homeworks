namespace Week9Hm2;

public class LazyStudent: Student1
{
    public override void Study()
    {
        Console.WriteLine($"Lazy student {_name} doesn't want to study.");
    }

    public override void Read()
    {
        Console.WriteLine($"Lazy student {_name} is skipping reading.");
    }

    public override void Write()
    {
        Console.WriteLine($"Lazy student {_name} is doodling instead of writing.");
    }

    public override void Relax()
    {
        Console.WriteLine($"Lazy student {_name} is relaxing all day!");
    }
}