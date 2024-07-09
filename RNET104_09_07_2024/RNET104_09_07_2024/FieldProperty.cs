namespace RNET104_09_07_2024;

public class FieldProperty
{
    #region Notes
    //Field - Classın scopeları daxilində təyin edilmiş(declare) dəyişənlər(variable) FIELD adlanır.
    //Fieldların local variabledan fərqi ondadır ki, təyin olunan zaman dəyər mənimsədilməsi(initialize) baş verməzsə özünə  öz tipinə uyğun olaraq default dəyəri götürür.

    //Property - Get və ya Set methoduna sahib Fieldlardır. Assembly səviyyəsində Get və Set methodları özü avtomatik generate olur və Field şəklində saxlanılır.

    //Readonly Field - Readonly fieldlar Readonly keyword vasitəsilə təyin olunur.Yalnız declare olunduğu və Constructor daxilində dəyər set edilə bilər.

    //Readonly Property - Readonly propertylər get methoduna sahib olan lakin set methoduna sahib olmayan propertylərdir.

    //Init only - Yalnız propertylərdə bu hal mövcuddur. Readonlydən fərqli olaraq, Declare zamanı və Constructor daxildə təyin olunma ilə yanaşı object initialize zaman da dəyər set edilə bilər.
    #endregion

    public readonly string surname = "Testov";
    public int Age { get; } = 0;
    public string Code { get; set; }

    public string Ronaldo { get; init; } = "Value1";
    
    public FieldProperty()
    {
        
    }

    public FieldProperty(int age, string surname,string ronaldo)
    {
        Age = age;
        this.surname = surname;
        Ronaldo = ronaldo;
    }

    public void SetDataToReadonly()
    {
        /*Age = 5;
        surname = "Testli";*/
    }


/*   Encapsulation
 *   private string _name;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }*/

}
