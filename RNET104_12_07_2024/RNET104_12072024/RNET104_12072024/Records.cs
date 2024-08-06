namespace RNET104_12072024;

public record Records(int MyProperty, int MyProperty1);

public record Records2
{
    public int MyProperty { get; }
    public int MyProperty1 { get; init; }

    public Records2(int myParameter, int myParameter1)
    {
        this.MyProperty = myParameter;
        this.MyProperty1 = myParameter1;
    }
}


public class TestClass
{
    public int MyProperty { get; set; }
    public int MyPropert1 { get; set; }

    public TestClass(int val1,int val2)
    {
        MyProperty = val1;
        MyPropert1 = val2;
    }
}


public class MyImmutableClass
{
    public int MyProperty { get; }
    public int MyProperty1 { get; init; }
    //public int MyProperty3 { get; set; } //=>  Bu hall Classın immutable olmasının qarşısını alır
}

