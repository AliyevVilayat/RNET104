namespace RNET104_11_07_2024;

#region Notes

/* Non-static
 
    * Non-static class - Ramda heç bir yer tutmur, ramda yer tutan classdan alınan instancelardır. Non-static class daxilində həm static həm də non-static memberlar yer alır.

    * Non-static class members:

      Non-static memberlar həm də instance memberlar olaraq adlandırılırlar.

    * Non-static method daxilində həm static həm də non-static memberları istifadə edə bilərik.
*/

/*Static class - 
 
    Static classdan instance almaq olmur. Çünki implicitly olaraq Sealed classdır.

    Static class daxilində yalnız və yalnız static memberlar yer ala bilər.
 
    Çünki static class program run olan zaman ramda(heap yaddaşda) saxlanılır. Və program var olduğu müddətcə mövcud olur.

    * Static Members
    
         Static memberlar instance'a yox class'a bağlı olurlar yəni yalnızca Class adı ilə müraciət oluna bilərlər.

         Static memberlar non-instance memberlar olaraq adlandılır.
 
 
    * Static constructor - Static olaraq declare olunan hər hansısa bir property və ya field'a başlanğıc dəyər assign etmək üçün istifadə olunur.

     Classa ilk müraciət olunduğu zaman yalnızca bir dəfə işə düşür (program ilk run olan zaman yox, run olunduqdan sonra classa ilk müraciət edilən zaman).

     Heç bir overload halı mövcud deyil və bu da o deməkdir ki parameterless olmalıdır. Kənardan call oluna bilmir. Kənardan call oluna bilmədiyi üçün declare olan zaman access modifier yazılmır. Əks hallda error verir.

    
    * Static method daxilində isə yalnız və yalnız static memberları istifadə edə bilərik.
*/

#endregion

public class StaticNonStatic
{
    public static int Age { get; set; }

    public StaticNonStatic()
    {
        Console.WriteLine("Non static constructor has been already executed");
    }

    public StaticNonStatic(int age) : this()
    {
        Age = age;
    }


    static StaticNonStatic()
    {
        Console.WriteLine("Static constructor has been already executed");
    }



    public void NonStaticMethod()
    {
        Age = 5;
    }

    public static void StaticMethod()
    {
        Age = 5;
    }
}

