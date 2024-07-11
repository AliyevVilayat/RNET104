namespace RNET104_11_07_2024;

#region Notes

/*Extension methods
 
Biz hər hansısa bir modulun source kodlarına müdaxilə edərək yeni bir funksionallıq artırmaq əvəzinə Extension methodlar təyin edərək lazımı əməliyyatları icra edə bilərik.(Open closedan da istifadə edilir)

Extension methodlar Static class daxilində yer alır və bu səbəbdən də məcburi olaraq static olur.

Methodun qəbul etdiyi ilk parameter this keyword'ü ilə işlənməlidir və this keyword tətbiq olunan parameter tətbiq olunacaq tipin obyekti olmalıdır.


 */


#endregion
public static class ExtensionMethod
{
    public static bool IsExist(this int[] array, int value)
    {
        foreach (int i in array)
        {

            if (i == value)
            {
                return true;
            }
        }
        return false;
    }
    /* Error alırıq Method signature eynidir.
     public static bool IsExist(int[] array,int value)
    {
        foreach (int i in array) {

            if (i == value)
            {
                return true;
            }
        }
        return false;
    }*/
}
