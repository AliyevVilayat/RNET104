

//If - then

using RNET104_08_07_2024;
using System.Linq.Expressions;
/*
int age = 22;
if (age == 21)
{
    Console.WriteLine("Happy birthdate Hakim");
}

Console.WriteLine("Party bitdi.");


//If - then - else

if (age == 22)
{
    //Şərt ödəndiyi zaman true halına uyğun olaraq əməliyyatlar burada icra olunacaq.
    Console.WriteLine("22 yaş tamam oldu.");
}
else
{
    //Şərt ödənmədiyi zaman yəni false halına uyğun olaraq əməliyyatlar burada icra olunacaq.
    Console.WriteLine("22 yaş tamam olmadı");
}*/

//Else if
// Ay adına görə hansı fəsildə olduğumuzu tapan proqramı yazın.


/*string month = "Iyun";
if(month == "Dekabr" || month == "Yanvar"|| month == "Fevral")
{
    Console.WriteLine("Qış fəsli");
}
else if (month == "Dekabr" || month == "Yanvar" || month == "Fevral")
{

}
else if (month == "Iyun" || month == "Iyul" || month == "Avqust")
{
    Console.WriteLine("Hal hazırda yay fəslindəyik");
}
else
{
    Console.WriteLine("Else hall");
}*/

/*string month = "Yanvar";
switch (month)
{

    case "Yanvar":
        goto case "Iyun";

    case "Fevral":
        Console.WriteLine("Fevral");
        break;

    case "Iyun":

    case "Iyul":
        Console.WriteLine("Iyul");
        break;

    default:
        Console.WriteLine("Daxil edilen deyer odenmir");
        break;


}*/

/*
static string TestMethod()
{
    return string.Empty;
}
string weekday = "Cume";

var result = weekday switch
{
    "Bazarertesi" => TestMethod(),

    "Cersenbe axsami" => "Test",
    "Cume" => "Test",
    _ => "Test"
};

_ = weekday switch
{
    "Bazarertesi" => Console.Write("test"),
    _ => Console.WriteLine("Default")
};*/


/*int age = 17;
bool isLegal = (age>=18)? true:false;
Console.WriteLine(isLegal);
*/


/*//Infinity Loop (For)

for(; ; )
{
    Console.WriteLine("Test");
}*/

/*foreach(var x in Enumerable.Range(0, 10))
{
    Console.WriteLine(x);
}*/


/*
Console.Write("Zehmet olmasa yaratmaq istediyiniz arrayin olcusunu qeyd edin:");
int arrLength = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arrLength];
int num = default;
for (int i = 0; i < arrLength; i++)
{
    Console.Write($"Arrayin {i + 1}. elementini daxil edin: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Arrayin elementleri:");
foreach (int i in arr)
{
    Console.Write(i);
    Console.Write(" ");
}

int[] newArr = { 1, 2, 3 };
int[] newArr2 = new int[] { 1, 2, 3 };*/

//Increment
//Prefix => ++num  <=>  ++5 = 6
//Postfix => num++ <=> 5++ 5; => 6


int num = 5;

int sum = --num + num-- + num + num--;

// 4+4+3+3

Console.WriteLine(sum);//sum = 14
Console.WriteLine(num);//num = 2


// 6 + 5
//5 + 6
//5+7
//

/*num = 5;
Console.WriteLine(++num + num++);

num = 5;
Console.WriteLine(num++ + num++);

num = 5;
Console.WriteLine(++num + ++num);*/
