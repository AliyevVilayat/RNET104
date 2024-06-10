#region NOTES

//Polymorphism => çox biçimlilik deməkdir və iki yerə bölünür. Dynamic(Runtime) və Static(Compiletime). Overload bizim üçün Static Polymorphismdir. Override isə Dynamic Polymorphismdir.
#endregion


using RNET104_10062024_2;

/*Car car = new Car(2024,"Mercedes","GLS Maybach 600",80,0.25,70);
Car car2 = new Car(2024,"Mercedes","GLS Maybach 600",80,0.25,70);
Car car3= new Car(2024,"Mercedes","GLS Maybach 600",80,0.25,70);

Console.WriteLine(Car._currentFuel);


car.ShowInfo();
car2.ShowInfo();
car3.ShowInfo();

*/
Vehicle vehicle = new Vehicle(2024);

Vehicle vehicle2 = new Car(2024, "Mercedes", "GLS Maybach 600", 80, 0.25, 70);

Car vehicle3 = new Car(2024, "Mercedes", "GLS Maybach 600", 80, 0.25, 70);


vehicle.ShowInfo();
vehicle2.ShowInfo();
vehicle3.ShowInfo();