namespace RNET104_11_07_2024;

#region Notes

//Constructor - return type'a sahib olmayan, class'dan object instance alınan zaman işə düşən methoddur.

//Default constructor - Parameterless, boş constructor. Əgər class daxilində heç bir constructor declare olunmayıbsa və ya default constructor ovveride edilməyibsə bu zaman Assembly səviyyəsində Default constructor generate olunacaq. Assemvlydə constructorlar ctor olaraq adlandırılır.

//Constructor call - Əgər Constructor hər hansısa bir Constructor'u call edirsə, bu zaman ilk növbədə call olunan Constructor execute olur. Bir Constructor yalnızca bir Constructor'u call edə bilər.

//Base - Hər hansısa bir base class'dan miras alınarsa, derived class object'i instance alınan zaman base class'dan da instance alınmış olur. Derived class'dan instance alınan zaman əgər base class'ın hər hansısa constructor'u call edilməyibsə  base class daxilində boş constructor varsa call olunacaq yoxdursa error verəcək.
#endregion


public class BaseClass
{
    public int Id { get; set; }

    public BaseClass()
    {

    }
    public BaseClass(int id)
    {
        Id = id;
    }
}

public class Constructors : BaseClass
{
    public string Description { get; }
    public double Price { get; set; }

    public Constructors(int id) : base(id)
    {
        Description = "DefaultValue";
    }
    public Constructors(int id, string description)
    {
        Console.WriteLine(id);
        Description = description;
    }

    public Constructors(int id, string description, double price) : this(id, description)
    {

        Price = price;
    }

}

