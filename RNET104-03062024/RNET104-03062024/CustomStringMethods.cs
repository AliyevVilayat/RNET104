using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNET104_03062024
{
    public class CustomStringMethods
    {
        public static string Convert(string name, string surname, string domain)
        {
            return null;
        }


        //Custom  UpperCase
        public static string ConvertToUpperCase(string str)
        {
            char symb;
            string upperStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                symb = str[i];
                if (!(symb >= 65 && symb <= 90 || symb>=97 && symb<=122) )
                {
                    continue;
                }

                if (symb >= 97 && symb <= 122)
                {
                    symb = (char)(symb - 32);
                }

                upperStr += symb;
            }
            return upperStr;
        }

        //Custom Replace
        public static string ChangeTheSymb(string str, char oldSymb, char newSymb)
        {
            string newStr = String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == oldSymb)
                {
                    newStr += newSymb;
                }
                else
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }

        //ToUpperCase First Letter
        public static string ConvertToCapitalLetter(string str)
        {
            char symb = str[0];
            if (symb >= 97 && symb <= 122)
            {
                symb = (char)(symb - 32);
            }
            string newVersion = symb.ToString();




            for (int i = 1; i < str.Length; i++)
            {
                symb = str[i];
                if(symb >= 65 && symb <= 90)
                {
                    symb = (char) (symb + 32);
                }

                newVersion += symb;
            }
            

            return newVersion;
        }
    }
}
