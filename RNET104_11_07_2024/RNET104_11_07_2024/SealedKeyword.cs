namespace RNET104_11_07_2024;

#region Notes

/* SEALED
 
    Sealed möhürlənmiş deməkdir. Classlar və methodlar C# daxilində Sealed keyword vasitəsilə təyin oluna bilərlər.

    Sealed keyword vasitəsilə təyin olunmuş Classlar heç bir classa miras vermir. Yəni bu class sonuncu class sayılır.
    
    Sealed keyword vasitəsilə təyin olunmuş Methodlar isə Override edilə bilmir. Yəni sonuncu versiyaya sahib olur. 
 */

#endregion
public sealed class SealedKeyword
{


}

public class BaseClass2 { 
    
    public virtual void Test()
    {

    }

}
//public class DerivedClass: SealedKeyword { } => error alırıq.

public class DerivedClass:BaseClass2
{
    public sealed override void Test()
    {
        
    }
}

/*public class TestDerivedClass : DerivedClass
{
    public override void Test()
    {
        base.Test();
    }
}
//error alırıq
 
 */
