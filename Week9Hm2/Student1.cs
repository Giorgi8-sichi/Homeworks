namespace Week9Hm2;

public class Student1
{
    public string _name { get; set; }



    public virtual void Study()
    {
        Console.WriteLine($"{_name} is Studying");
    }

    public virtual void Read()
    {
        Console.WriteLine($"{_name} is reading!");
    }

    public virtual void Write()
    {
        Console.WriteLine($"{_name} is writing");
    }

    public virtual void Relax()
    {
        Console.WriteLine($"{_name} is Relaxing");
    }
}