
using RNET104_12072024;

/*string name = "Test";

string name2 = "SecondValue";
string name3 = "SecondValue";

Console.WriteLine(name == name2);
Console.WriteLine(name == name3);
Console.WriteLine(name3 == name2);

//Stringlər IMMUTABLE type olduqları üçün onlara yeni dəyər mənimsədən zaman əvvəlki obyekt(yəni value) string poolda saxlanılır və yeni obyekt yaranaraq refere edilir.*/


TestClass obj1 = new TestClass(1,2);

TestClass obj2 = new TestClass(1,2);

Console.WriteLine(obj1 == obj2);


Records recordObj = new(1,2);
Records recordObj2 = new(1,2);
Console.WriteLine(recordObj==recordObj2);