namespace RNET104_12062024;

//Polymorphism - Çox biçimlilik.
// Polymorphism 2 yerə bölünür: Runtime(Override) və Compiletime(Overload)

public class ClassForOverride
{
    public virtual void MyCustomMethod()
    {
        Console.WriteLine("Hello World");
    }

    public virtual void MyCustomMethod(string name)
    {
        Console.WriteLine("Hello World");
    }
}

public class Polymorphism : ClassForOverride
{
    public sealed override void MyCustomMethod()
    {
        Console.WriteLine("Bu bir Parameterless methoddur.");
    }

}



