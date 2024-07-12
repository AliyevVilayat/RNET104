namespace RNET104_10_07_2024;

public class DefautlValueExample
{
    /*public void MyMethod(string name = "Test", params object[] surnames)
    {
        Console.WriteLine($"Fullname: {name} {surname} , Age: {age}");
    }*/
}

public class OptinalParameters
{
    //Gonderilen ededler toplusunun cemini geri qaytaran method tertib edin.
    public static int Sum(int num)
    {

        return num;
    }

    public static int Sum(int num1, int num2 = 5)
    {

        return num1 + num2;
    }

    public static int Sum(params int[] nums)
    {
        int sum = default;
        foreach (int i in nums)
        {
            sum += nums[i];
        }
        return sum;
    }

    public static void Test()
    {
        Console.WriteLine(Sum(1));
        Console.WriteLine(Sum(1,2,3));
    }
}
