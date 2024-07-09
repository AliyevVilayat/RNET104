namespace RNET104_09_07_2024;

public class RefOut
{
    #region Notes

    //Out - Başlanğıc dəyər verilməsə belə out keyword vasitəsi ilə təyin olunan parametrə, variable göndərilə bilər lakin method daxilində out keyword vasitəsi ilə gələn variabla dəyər mənimsədilməlidir(assign edilməlidir).

    //Ref - Başlanğıc dəyər MÜTLƏQ verilməlidir lakin method daxilində ref keyword vasitəsi ilə gələn variabla dəyər mənimsədilməsə də olar(assign məcburiyyəti yoxdur).

    #endregion

    public static void ChangeValueOut(out int age)
    {
        age = 11;

        Console.WriteLine($"From Method: {age}");
    }

    public static void ChangeValue(ref int age)
    {
        

        Console.WriteLine($"From Method: {age}");
    }

    public static void ChangeValue(int age)
    {
        age = 12;
        Console.WriteLine($"From Method: {age}");
    }
}
