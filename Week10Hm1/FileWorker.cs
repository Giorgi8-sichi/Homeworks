namespace Week10Hm1;

public abstract class FileWorker
{
    public int  _maxStorage { get; set; }
    public abstract string _file { get; set; }



    public abstract void Read();
    public abstract void Write();
    public abstract void Edit();
    public abstract void Delete();
}