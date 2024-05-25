

#region Notes

// "" or string.Empty => eyni mənanı verir.


//Console.ReadKey() - sadəcə 1 simvol qəbul edir.
//Console.ReadKey(true) və ya Console.ReadKey(intercept:true) - qəbul edilən simvolu göstərmir 
//Method geriyə KeyInfo tipində dəyər qaytarır.
//KeyInfo tipində olan object'in KeyChar propertisi ilə daxil olunan simvolu əldə edə bilərik.
//Char.IsDigit(char digit) methodu ilə daxil olunan simvolun ədəd olub olmamasını yoxlayırıq.


//Is Digit, IsLetter, IsLetterOrDigit


#endregion













#region ReadKey

/*
Console.Write("Zehmet olmasa simvolu daxil edin:");
ConsoleKeyInfo keyinfo = Console.ReadKey(true);
char mySymb = keyinfo.KeyChar;

bool isDigit = Char.IsLetterOrDigit(mySymb);
if (isDigit)
{
Console.WriteLine("Sizin daxil etdiyiniz simvol eded ve ya herfdir. ");
}
else
{
    Console.WriteLine("daxil etdiyiniz simvol eded deyil");
}

Console.WriteLine(mySymb);
 */

#endregion


/*try
{
    Console.Write("Zehmet olmasa ededi daxil edin: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Daxil edilen eded: " + num);
    Console.WriteLine($"Daxil edilen eded: {num}");
    Console.WriteLine("Daxil edilen eded: {0}", num);

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Finally block always executes");
}*/




#region CustomArrayResize

int[] oldArr = new int[3] {1,2,3};

Console.Write("Arrayin yeni uzunlugunu daxil edin:"); //1. Yeni uzunluq qeyd edilir.
int length = Convert.ToInt32 (Console.ReadLine());

if(length>oldArr.Length)
{
    int[] newArr = new int[length]; //2. Yeni uzunluqda yeni bir array yaradildi
    for (int i = 0; i < oldArr.Length; i++)
    {
        newArr[i] = oldArr[i];
    }
    for (int i = 0; i < newArr.Length; i++)
    {
        Console.WriteLine(newArr[i]);

    }
}
else
{
    Console.WriteLine($"Uzunlugu {oldArr.Length}-den boyuk daxil edin");
}



//3. Kohne arrayin elementleri bura assign edilsin.



#endregion





int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
//index => 0, .. , length -1


Array.Resize(ref numbers, numbers.Length);


int[] numbers2 = numbers;

Console.Write("Numbers array's elements: ");
foreach (int number in numbers)
{
    Console.Write(number);
    Console.Write(" ");
}
/**/


//Baxacayiq
/*int num = Console.Read();
if(num == -1)
{
    Console.WriteLine("Soz daxil edildi");
}
*/

