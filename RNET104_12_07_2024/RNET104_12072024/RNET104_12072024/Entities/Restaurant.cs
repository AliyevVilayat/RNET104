using RNET104_12072024.Entities;

namespace RNET104_12072024;


/*
Restaurant class'ın xüsusiyyətləri:
Name 
Address 
Menu (restoranın menyusu, yəni Dish obyektlərinin siyahısı)
Orders (verilən sifarişlərin siyahısı)

Not: Name property olmadan Restaurant class'dan instance alına bilməsin

Restaurant class'ın davranışları(methods):
Restaurant class'da, Menuya yemək əlavə edən bir method yazın (məsələn, AddDishtoMenu or AddDish).+
Restaurant class'da, Sifarişlər listinə, sifariş əlavə edən bir method yazın (məsələn, PlaceOrder).+
Restaurant class'da, OrderId ilə sifarişlər listindən həmin Id'ə sahib Orderi(əgər varsa)return edən bir method yazın (məsələn, GetOrderById).+

*/
public class Restaurant : BaseEntity
{
    
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dish> Menu { get; set; }
    public List<Order> Orders { get; set; }


    public Restaurant(string name)
    {
        Name = name;
        Menu = new List<Dish>();
        Orders = new List<Order>();
    }

}
