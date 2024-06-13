namespace RNET104_12062024;

public class SealedExamples:ChildClass
{
    public void Run()
    {
        Console.WriteLine("Saata 17KM");
    }
}


public class ParentClass
{
    public virtual void Run()
    {
        Console.WriteLine("Saata 7KM");
    }
}

public class ChildClass : ParentClass
{
    public sealed override void Run()
    {
        Console.WriteLine("Saata 17KM");
    }
}
