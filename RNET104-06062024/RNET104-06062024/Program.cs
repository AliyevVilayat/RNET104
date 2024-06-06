using RNET104_06062024;
/* Examples
string brand = "Mercedes";
string model = "C-Class";

string brand2;


var model2 = "S-Class";

string[] brands = new string[3] { "Mersedes", "BMW", "Audi" };
brands[0] = "Mercedes";



var car = new {

    brand = "Mersedes",
    model = "GLS 680",
    fuelCapacity = 80.0

};

Console.WriteLine(car.brand);
car.brand = "Mercedes";
car.model = "Mercedes";
car.fuelCapacity = "Mercedes";
*/

/*ExamplesForObjectReference

Car car;
Car car2 = new Car();
new Car();



car.brand = "Test";
car2.brand = "Test";

*/





var car3 = new Car();

Console.WriteLine("Zehmet olmasa nəqliyyat vasitəsinin brand-ni daxil edin:");
string brand = Console.ReadLine();

Console.WriteLine("Zehmet olmasa nəqliyyat vasitəsinin model-ni daxil edin:");
string model = Console.ReadLine();

Console.WriteLine("Zehmet olmasa nəqliyyat vasitəsinin fuelCapacity-ni daxil edin:");
int fuelCapacity= Convert.ToInt32(Console.ReadLine());

car3.brand = brand;
car3.model = model;
car3.fuelCapacity = fuelCapacity;


Console.WriteLine("Daxil edilmiş nəqliyyat vasitəsinin brand-i:"+car3.brand);
Console.WriteLine("Daxil edilmiş nəqliyyat vasitəsinin model-i:" + car3.model);
Console.WriteLine("Daxil edilmiş nəqliyyat vasitəsinin fuelCapacity-i:" + car3.fuelCapacity);





/*
Car car = new Car();
Car car2 = new();
car.brand = "Mercedes";                 //=> set
Console.WriteLine(car.brand);           //=> get
string brand = car.brand;               //=> get

*/


