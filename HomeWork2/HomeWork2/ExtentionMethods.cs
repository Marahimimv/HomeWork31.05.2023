using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{

    static class Extensions
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 1) 
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool IsContains(this string str)
        {
            bool DigCheck = false;
            for(int i=0; i<str.Length; i++)
            {
                if (!char.IsDigit(str[i])) 
                {
                    DigCheck = true; 
                }
                else
                {
                     DigCheck = false;
                }
            }
            return DigCheck;
        }
        public static string ToCapitalize(this string str)
        {
            return str.Substring(0,1).ToUpper()+str.Substring(1).ToLower();
        }
        public static int[] GetValueIndexes(this string str, char symbol)
        {
            int[] arr = { };
            for(int i =0; i<str.Length;i++)
            {
                if (str[i] == symbol)
                {
                    Array.Resize(ref arr,arr.Length +1);


                    arr[arr.Length-1] = i;
                }
            }
            return arr;
            

        }

    }
}
