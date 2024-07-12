using RNET104_12072024.Entities;
using System.Diagnostics;

namespace RNET104_12072024;

/*Category class'ın xüsusiyyətləri:+
Id 
Name 
Description (kateqoriyanın təsviri)
Dishes (kateqoriyaya aid olan yeməklərin siyahısı)

Not: Id və Name property'lər olmadan Category class'dan instance alına bilməsin+
----------------------------------------------------------------------------------
*/

public class Category:BaseEntity
{

    public string Name { get; set; }
    public string Description { get; set; }
    public List<Dish> Dishes { get; set; }

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
        Dishes = new List<Dish>();
    }
}
