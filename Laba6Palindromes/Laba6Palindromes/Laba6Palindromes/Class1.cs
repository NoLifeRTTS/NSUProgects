using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6Palindromes
{
    public static class PalSearch
    {
        public static bool Pal(this int number)
        {
            bool check = true;
            int len = number.ToString().Length;
            int c = len;
            for(int i = 1; i <= len/2; i++)
            {
                if (number % 10 != number / (int)Math.Pow(10, c-1))
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                    c -= 1;
                    number /= 10;
                    number %= (int)Math.Pow(10, c - 1);
                    c = number.ToString().Length;
                }
            }
            return check;
        }
    }
}
