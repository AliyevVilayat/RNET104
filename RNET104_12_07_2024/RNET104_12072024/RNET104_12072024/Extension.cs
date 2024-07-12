//List<Dish> obyekti üçün extension method yazın  (Sum).
//Not: Tətbiq olunan list daxilindəki yeməklərinin qiymətlərinin cəmini tapsın.

namespace RNET104_12072024;

public static class Extension
{

    public static double CalculateTotalPrice(this List<Dish> dishes)
    {
        /*        double total = 0;
                foreach (Dish dish in dishes)
                {
                    total += dish.Price;
                }*/

        double totalPrice = dishes.Sum(d => d.Price);

        return totalPrice;
    }
}
