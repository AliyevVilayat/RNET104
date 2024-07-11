namespace RNET104_11_07_2024;
#region Notes

// CTRL + R + G - lazımsız olan usingləri silir.

/*Const
 
    Yalnızca fieldlar constant olaraq təyin oluna bilərlər. Bu xüsusiyyət propertylərə aid edilmir.
    Constant olaraq təyin olunmuş fieldlara mütləq və mütləq təyin olunduqları(declare) yerdə deyər assign olunmalıdır. Başqa heç bir yerdə dəyər assing ola bilməz.

    Objectə yox Classa xass bir dəyişəndir. Bu səbəbdən yalnız və yalnız class vasitəsilə ilə müraciət edə bilərik.
 
 */

#endregion

public class Constant
{

    public int age; //=> field 
    public readonly string name; // => readonly field
    public const string surname = "Testov"; // => const field

    public int Age { get; set; } // => property
    public string Name { get;  } // => readonly property
    public string Surname { get; init; } // => init only property

}
