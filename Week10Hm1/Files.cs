namespace Week10Hm1;

public  class Files: FileWorker
{
    public override string _file { get; set; }
    
    public override void Read()
    {
        Console.WriteLine($"I Can Read to-- {_file} --file with max storage-- {_maxStorage}");
    }
    public override void Write()
    {
        Console.WriteLine($"I Can Write to-- {_file} --file with max storage-- {_maxStorage}");
    }

    public override void Edit()
    {
        Console.WriteLine($"I Can Edit to-- {_file} --file with max storage-- {_maxStorage}");
    }

    public override void Delete()
    {
        Console.WriteLine($"I Can Delete to-- {_file} --file with max storage-- {_maxStorage}");
    }
}