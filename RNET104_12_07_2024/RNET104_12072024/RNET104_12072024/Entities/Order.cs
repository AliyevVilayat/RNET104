using RNET104_12072024.Entities;

namespace RNET104_12072024;

/*
Order class'ın xüsusiyyətləri:+
Id 
Dishes 
TotalAmount (sifarişin ümumi məbləği)

Not: Id property olmadan Order class'dan instance alına bilməsin*/
public class Order : BaseEntity
{
    
    public string Name { get; set; }
    public List<Dish> Dishes { get; set; } 
    public double TotalAmount => Dishes.CalculateTotalPrice();
    //public double TotalAmount { get { return Dishes.CalculateTotalPrice(); } }

    public Order(int id)
    {
        Id = id;
        Dishes = new List<Dish>();
    }
}


