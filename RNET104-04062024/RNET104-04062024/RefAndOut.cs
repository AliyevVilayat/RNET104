namespace RNET104_04062024;


public static class RefAndOut
{

    public static void RefExample(ref int num)
    {
        int a = 5;
        int b = 6;
        int sum = a + b;
        Console.WriteLine();
    }

    public static void OutExample(out int sum)
    {
        int num1 = 5;
        int num2 = 10;
        sum = num1 + num2;
    }

    public static void MyTestMethod(int num2, string str, int num1)
    {

    }

    public static void MyTestMethod(int num2, int num1, string str)
    {

    }

    public static void MyTestMethod(int num1, int num2)
    {

    }


    public static void MyTestMethod()
    {

    }

    public static void MyTestMethod(int num2)
    {

    }

    public static void MyTestMethod(string num2, int num1)
    {

    }

}



