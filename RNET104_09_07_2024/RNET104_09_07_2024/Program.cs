/*

using RNET104_09_07_2024;

//Console.WriteLine(TaskSolution.MethodExpression(-1));

//NullCoalescingOperators.UseNullCoalescing();


string name = "Nurlan";
string surname = "Memmedov";

string name1 = "Hakim";
string surname2 = "Hebibli";

//......


var student = new
{
    Name = "Nurlan",
    Surname = "Memmedov"
};

Console.WriteLine($"Student:{student.Name} {student.Surname}");

//student.Surname = "Memmedzade"; error

var student2 = new
{
    Name = "Hakim",
    Surname = "Hebibli"
};



Student student3 = new Student();
student3.Name = "Kamal";
student3.Surname = "Pashayev";

Student student4 = new Student()
{
    Name = "Yagmur",
    Surname = "Novruzlu"
};

object obj =  student3;


FieldProperty myObj = new()
{
    Code = "RNET104",
    Ronaldo = "SIÜÜÜÜ"
};

FieldProperty myObj2 = new(1,"test","test")
{

};


*//*Console.WriteLine(myObj.age);
myObj.age = 1;
int age;
Console.WriteLine(age);*/


using RNET104_09_07_2024;
//Ref
int age = 10;
Console.WriteLine(age);

RefOut.ChangeValue(ref age);
Console.WriteLine(age);

/*Out
 int age;

RefOut.ChangeValueOut(out age);
Console.WriteLine(age);*/