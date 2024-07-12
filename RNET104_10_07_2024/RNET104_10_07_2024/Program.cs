using RNET104_10_07_2024;


/*
int a = 5;
int b = 10;
int c = a + b;
Console.WriteLine(c);
a +b //=> -5*/

MyInt obj1 = new(10);
MyInt obj2 = new(1);
MyInt result = obj1 + obj2;
Console.WriteLine(result.Value);