namespace RNET104_06062024;
class Car
{

    #region Notes
    //Class daxilində hər hansısa bir data saxlamaq üçün Fieldlardan istifadə etməliyik.

    //Field nədir? Class'ın scopeları daxilində təyin olunmuş(declare) dəyişənlər(variable) FIELD adlanır. Bu sayədə biz HƏR BIR OBJECT'ə xas olan xüsusiyyətləri burada saxlayırıq.

    //Field'ların Local Variable'lardan fərqi ondadır ki, defautl dəyərə malik olurlar. Bildiyimiz kimi Local variable'lara biz dəyər mənimsətməzsək heç bir dəyərə sahib olmurlar.

    #endregion

    public string brand;
    public string model;
    public int fuelCapacity;
    public double fuelFor1Km;
    public double currentFuel;
}



//data saxıamaq məqsədi classlar arasında data göndərməkdir mi?
//private field;

/*
 - Brand
 - Model
 - FuelCapacity
 - FuelFor1Km
 - CurrentFuel
 - ShowInfo()
*/
