#region Ref&Out

//Ref olaraq göndərilən arqument başlanğıc bir dəyərə MÜTLƏQ sahib olmalıdır yəni biz unassing variable göndərə bilmərik. Method daxilində isə yeni bir dəyər assing edilməsə də olar.


//Out olaraq göndərilən arqument unassing variable ola bilər yəni dəyər mənimsətmək kimi bir məcburityyət yoxdur. Lakin method daxilində mütləq dəyər mənimsədilməlidir. 

//Method Siganture: Method name,  Parameter types,Parameter count, Parameters' queue(yəni qəbul edilmə ardıcıllığı)

//Var keyword ilə method parameter təyin etmək olmaz.




using RNET104_04062024;
using System.ComponentModel;

/*Ref example
 * int num = 10;
Console.WriteLine("Before Incrementing:" + num);

RefAndOut.RefExample(ref num);
Console.WriteLine("After Incrementing:" + num);*/

/* Out example
 * int sum;
RefAndOut.OutExample(out sum); //Bu method sayəsində zatən dəyər MÜTLƏQ assign edilmiş olur .

Console.WriteLine("Sum:"+sum);*/





#endregion