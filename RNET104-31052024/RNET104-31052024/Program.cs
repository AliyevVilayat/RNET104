string str = "It's a text for testing";
#region Length  

//Length => myStingObj.Length , Geriyə tətbiq olunan string obyektin uzunluğunu qaytarır.

int length = str.Length;

for (int i = 0; i < str.Length; i++)
{
    //Console.Write(str[i] + " ");
}
#endregion

#region Clone
//Clone() => myStingObj.Clone();  Tətbiq olunan obyektin clone'nu geriyə qaytarır
string str2 = (string)str.Clone();

#endregion

#region Concat

//Concat() => myStingObj.Concat(myStingObj2);  Tətbiq olunan obyekt ilə argument'i birləşdirir yəni Join edir və ya Concat edir. 


string str3 = "RNET";
string str4 = "104";
string strLastVersion = str3 + " " + str4;
Console.WriteLine(str3 + " " + str4);
Console.WriteLine($"{str3} {str4}");
Console.WriteLine($"{strLastVersion}");

str3.Concat(str4);

#endregion

#region Equals
//Equals daxilindəki dəyəri yoxlamaq üçündür. == operatoru ilə qarışdırmaq olmaz. Çünki zatən eyni dəyərə sahibdirlərsə o deməkdir ki eyni obyekti refere edirlər.

string str5 = "RNET104";
string str6 = "RNET-104";
string str7 = "RNET104";

string str8 = str5;

Console.WriteLine("str5 = str7? :"+String.ReferenceEquals(str5, str7));
Console.WriteLine("str5 = str8? :"+String.ReferenceEquals(str5, str8));

str8 = "RNET104";

Console.WriteLine(String.ReferenceEquals(str5, str8));
Console.WriteLine(str5.Equals(str8));

#endregion

#region Format

string str9 = string.Format("Test {0} {1}", "RNET", "104");
Console.WriteLine(str9);

#endregion

#region Split

string[] arr =  str.Split(" ");
foreach(var  item in arr)
{
    Console.WriteLine(item);
}
#endregion

#region SubString

string str10 = "BU bir test metnidir";
int size = 2;
Console.WriteLine(str10.Substring(size, str10.Length-size).Trim()); 
#endregion
