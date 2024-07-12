using RNET104_12072024.Entities;

namespace RNET104_12072024;


/*Dish class'ın xüsusiyyətləri(fields or properties):
Id 
Name
Price 
Category (yeməyin kateqoriyası, Category class obyekti) +

Not: Id, Name və Price property'lər olmadan Dish class'dan instance alına bilməsin+

Dish class'ın davranışları(methods): +

Dish class'da, Category obyektinə görə axtarış edə bilən bir method yazın (məsələn, FindDishesByCategory).
Not:Düşünürük ki, databasedən bizə List şəklində bütün yeməklər gəlir. Bu yeməkləri Category obyekti və ya Category Id vasitəsi ilə axtarış edək.+

List<Dish> obyekti üçün extension method yazın  (Sum).
Not:Tətbiq olunan list daxilindəki yeməklərinin qiymətlərinin cəmini tapsın.+
------------------------------------------------------------------------------*/

public class Dish:BaseEntity
{
    
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }

    public Dish(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public static List<Dish> FindDishesByCategory(List<Dish> dishList,Category category)
    {
        /* Find way 1
          List<Dish> sortedDishesList = new List<Dish>();   

        foreach(Dish dish in dishList)
        {
            if(dish.Category.id == category.id)
            {
                sortedDishesList.Add(dish);
            }
        }

        return sortedDishesList;*/


        List<Dish> newDishesList =  dishList.Where(d => d.Category.Id == category.Id).ToList();
        return newDishesList;

    }

}
