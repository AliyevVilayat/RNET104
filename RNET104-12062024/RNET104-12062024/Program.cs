#region Notes

//*Struct

//C# daxilindəki bütün value type’lar Struct olaraq yaradılmışdır.

//Struct’lar implicitly sealed olduğu üçün onlardan miras almaq olmur, və Struct’lar yalnız interface’lərdən miras ala bilər.

//Struct’ların regular class’lardan bir fərqi də odur ki, Struct daxilində boş constructor yazamadan parametrli constructor yazsaq belə Assembly səviyəsində özü yenə də boş constuctor’u əlavə edir.

//Struct’lar həmçinin immutable’dır. Struct’ların istifadə olunması səbəbi kiçik və az data’lar saxlamaq üçün və qısa davranışlar həyata keçirə bilmək üçün istifadə olunan bir model olması və performans cəhətdən sürətli olmasıdır.


//----------------------------------

//*Sealed
// Sealed - möhürlü, möhürlənmiş deməkdir.
// Sealed keyword ilə təyin olunmuş CLASS möhürlənir və ondan miras almaq olmur.
// Sealed keyword ilə təyin olunmuş Method möhürlənir və ondan sonra miras alınan CLASS daxilində override olmur.


#endregion

using RNET104_12062024;

ParentClass parentObj = new ParentClass();

ChildClass childObj = new ChildClass();

ParentClass childObj2 = new ChildClass();


parentObj.Run();
childObj.Run();
childObj2.Run();