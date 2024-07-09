namespace RNET104_09_07_2024;

public class MethodFunciton
{

    #region Notes

    //Parametr - Method declare olan zaman qəbul etdiyi dəyişənlər(yəni call edən zaman göndərməyimizi tələb etdiyi dəyişənlər) PARAMETR adlanır.


    //Argument - Method call olan zaman ona göndərilən dəyərlər(yəni Methodun qəbul etdiyi və bizdən call edən zaman göndərməyimizi tələb etdiyi dəyərlər) ARGUMENT adlanır.

    //Method Signature - Method name, qəbul etdiyi parametrlərin sayı, tipi və ardıcıllığı.
    //Nəzərə alınmır(Expect) - Return type, Access Modifier,Static&NonStatic Qəbul etdiyi parametrlərin adları

    #endregion

    public void Test(string name, int age, string code)
	{
        Console.WriteLine("Test");
    }

    public void Test(int age, string name,  string code)
    {
        Console.WriteLine("Test");
    }

    public void Test( string name, string code, int age)
    {
        Console.WriteLine("Test");
    }

    /*public void Test(string name, string code, out int age)
    {
        Console.WriteLine("Test");
    }*/

    public void Test(string code, string name, int age,int num)
    {
        Console.WriteLine("Test");
    }
}
