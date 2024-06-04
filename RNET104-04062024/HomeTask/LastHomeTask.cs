using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    public static class LastHomeTask
    {

        public static int[] AddArrayelements(int length)
        {
            int[] arr = new int[length];
            Random rndm = new Random();
            int randomNum;
            int index = 0;
            bool isExist;
            while (index < arr.Length)
            {

                randomNum = rndm.Next(1, 50);
                isExist = CheckExistElement(arr, randomNum, index);

                if (isExist)
                {
                    continue;
                }

                arr[index] = randomNum;
                index++;

            }

            return arr;

        }

        public static bool CheckExistElement(int[] arr, int element, int currentIndex)
        {

            // arr.Contains(element); => Custom
            bool isExist = false;
            int i = 0;
            while (i < currentIndex)
            {
                if (arr[i] == element)
                {
                    return true;
                }
                i++;
            }

            return isExist;
        }

    }
}
