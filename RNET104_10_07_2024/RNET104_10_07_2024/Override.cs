namespace RNET104_10_07_2024;

public class Override
{
    #region Notes




    #endregion


}

public class AnimalService
{
    public void Adopt(string ownerName, Animal animal)
    {
        Console.WriteLine($"Name: {animal.Name} animal has been adopted by from {ownerName}");
    }
}

public class Animal
{

    public virtual string Name { get; set; }
    public string Code { get; set; }

    public Animal(string name, string code)
    {
        Name = name;
        Code = code;
    }
    public virtual void Run()
    {
        Console.WriteLine("Animal is running");
    }
}

public class Cat : Animal
{

    public Cat(string name, string code) : base(name, code)
    {
    }
    public void Test()
    {

    }
    public override void Run()
    {
        Console.WriteLine("Cat is running");
    }


}

public class Dog : Animal
{
    public Dog(string name, string code) : base(name, code)
    {
    }

    public override void Run()
    {
        Console.WriteLine("Dog is running");
    }
}


public abstract class MyAbstractClass
{
    public abstract void AbstractMethod();
}

public interface IMyInterface
{
    public string Name { get; set; }
    void MethodFromInterface();
}

public class DerivedFromAbstract : MyAbstractClass, IMyInterface
{
    public string Name { get ; set; }

    public override void AbstractMethod()
    {
        throw new NotImplementedException();
    }

    public void MethodFromInterface()
    {
        throw new NotImplementedException();
    }
}