#region Notes

///Comment line ceterele + shift + slash
// && - and(və) qeyd edilən bütün şərtlər ödənərsə true dəyər qaytarır
// || - or(və ya) heç olmasa 1 şərt ödənərsə(true olarsa) true dəyər qaytarır.
//Value-a görə yoxlanış lazım olarsa else if əvəzində switch case istifadə edilir.

#endregion

#region Adlandirma

// int myNumber => Camel case yəni ilk söz kiçik hərflə başlayır, digərləri böyük hərflə başlayır.
// int MyNumber => Pascal case yəni hər sözün ilk hərfli böyük hərflə başlayır.
// int my_number => Snake case yəni hər bir sözün arasında underline(altxətt) yazılır.
// int my-number => Kebab case yəni hər bir sözün arasında dash(defis) yazılır C# daxilində bu cür adlandırma YOXDUR!

int myNumberTest = 5;
int MyNumberTest = 5;
int my_number_test_number = 5;

#endregion

#region If-Then

int numForIf = -2;
if (numForIf > 0)
{
    Console.WriteLine("Eded musbet ededdir");
}
Console.WriteLine("Her hansisa bir emeliyyat icra edildi");

#endregion

#region If-Then-Else

int numForIfElse = -2;
if (numForIfElse > 0)
{
    Console.WriteLine("Eded musbet ededdir");
}
else
{
    Console.WriteLine("Eded musbet eded deyil");
}
#endregion

#region ElseIf-e ehtiyyac

int gpaForExample = 91;

if (gpaForExample > 90 && gpaForExample <= 100)
{
    Console.WriteLine("GPA-ə əsasən tələbə A alır.");
}

if (gpaForExample > 80 && gpaForExample <= 90)
{
    Console.WriteLine("GPA-ə əsasən tələbə B alır.");
}

if (gpaForExample > 70 && gpaForExample <= 80)
{
    Console.WriteLine("GPA-ə əsasən tələbə C alır.");
}

#endregion

#region ElseIf

int gpa = 51;

if (gpa > 90 && gpa <= 100)
{
    Console.WriteLine("GPA-ə əsasən tələbə A alır.");
}
else if (gpa > 80 && gpa <= 90)
{

    Console.WriteLine("GPA-ə əsasən tələbə B alır.");
}
else if (gpa > 70 && gpa <= 80)
{

    Console.WriteLine("GPA-ə əsasən tələbə C alır.");
}
else
{
    Console.WriteLine("GPA cedveline uygun deyer daxil edilmedi");
}

#endregion

#region SwitchCaseNiye lazimdir?

int weekCode = 5;

if (weekCode == 1)
{
    Console.WriteLine("Bu gun Bazarertesidir");
}
else if (weekCode == 2)
{
    Console.WriteLine("Bu gun Cersenbe axsami");
}
else if (weekCode == 3)
{
    Console.WriteLine("Bu gun Cersenbe");
}
else if (weekCode == 4)
{
    Console.WriteLine("Bu gun Cumeaxsami");
}
else if (weekCode == 5)
{
    Console.WriteLine("Bu gun Cume");
}
else if (weekCode == 6)
{
    Console.WriteLine("Bu gun Senbe");
}
else if (weekCode == 7)
{
    Console.WriteLine("Bu gun Bazar");
}
else
{
    Console.WriteLine("Gonderilen code yanlisdir, heftenin bele bir gunu teyin edilmeyib.");
}

#endregion

#region SwitchCase

int hefteninGunu = 3;
//Value-un type-i bizim ifademize uygun olmalidir
switch (hefteninGunu)
{
    case 1:
        Console.WriteLine("Value uygun emeliyyat1");
        //..................
        Console.WriteLine("Value uygun emeliyyatN");
        break;

    case 2:
        Console.WriteLine("Value2 uygun emeliyyat");
        break;

    case 7:
        Console.WriteLine("ValueN uygun emeliyyat");
        break;
    default:
        Console.WriteLine("Hec bir case odenmediyi halda gelib bu emeliyyatlari icra edir");
        break;
}

string gun = "Bazar";
//Value-un type-i bizim ifademize uygun olmalidir
switch (gun)
{
    case "Bazar ertesi":
        Console.WriteLine("Value uygun emeliyyat1");
        //..................
        Console.WriteLine("Value uygun emeliyyatN");
        break;

    case "Cersenbe axsami":
        Console.WriteLine("Value2 uygun emeliyyat");
        break;

    case "Bazar":
        Console.WriteLine("ValueN uygun emeliyyat");
        break;
    default:
        Console.WriteLine("Hec bir case odenmediyi halda gelib bu emeliyyatlari icra edir");
        break;
}

#endregion