namespace RNET104_12072024.BusinessLogic;

public class RestaurantService
{

    public void AddDishToMenu(List<Dish> menu, Dish dish)
    {
        menu.Add(dish);
    }

    public void PlaceOrder(List<Order> orders, Order order)
    {
        orders.Add(order);
    }

    public Order? GetOrderById(List<Order> orders,int id)
    {
        /*        //GetById way 1
                foreach (var order in orders)
                {
                    if (order.Id == id)
                    {
                        return order;
                    }
                }

                //throw new OrderException("Order not found");
                return null;*/

        #region Single
        //Order order = orders.Single();
        //Single unique olduğundan əmin olduğumuz data axtaraşında istifadə olunur.
        //Single methodu əgər şərti ödəyən 1dən çox data olarsa exception qaytarır (Exception message: Sequence contains more than one elements.
        //Single methodu vasitəsi ilə axtarış zamanı əgər şərti ödəyən heç bir data qayıtmazsa bu zaman exception qaytarır.(Exception message: Sequence contains no elements)

        #endregion

        #region SingleOrDefault

        Order? order = orders.SingleOrDefault();
        return order;
        //Single methoddan fərqi ondadır ki, əgər şərti ödəyən data qayıtmazsa default dəyər return olunur.
        #endregion





    }
}
