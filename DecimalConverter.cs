using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Converter
{
   
  


   public class BinaryOctalHexTable
        {

        public static String toBinary(long Decimal)
        {
            String str = "";
            String strOctal = "";

            // modulus and divide by 8 to get correct 8's place value
            while (Decimal > 0)
            {
                str += (Decimal % 2);
                Decimal = Decimal / 2;
            }

            // reverse the result and construct string
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strOctal += str[i];
            }

            return strOctal;
        }



        public static String to4(long Decimal)
            {
                String str = "";
                String strOctal = "";

                // modulus and divide by 8 to get correct 8's place value
                while (Decimal > 0)
                {
                    str+=(Decimal % 4);
                Decimal = Decimal/4;
                }

                // reverse the result and construct string
                for (int i = str.Length - 1; i >= 0; i--)
                {
                strOctal += str[i];
                }

                return strOctal;
            }
        public static Boolean isValidate(long number, int Base)
        {
            while (number != 0)
            {
                if (number % 10 > Base - 1)
                {
                    return false;
                }
                else
                    number /= 10;

            }


            return true;
        }
        public static Boolean isValidate(String number)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            char[] dig = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            int i = 0;
            for( i=0; i<number.Length; i++)
            {
                char ni = number[i];
                int j = 0;
                while (j < digits.Length)
                {
                    if (ni.Equals(digits[j]))
                        return true;
                    j++;
                }

            }

            return false ;
        }
        public static long toDecimal(long num,int Base)
        {
            long converted = 0;
            long index = 0;
            long en;
            while (num != 0)
            {
                en = num % 10;
                converted += (long)(en * Math.Pow(Base, index));
                num /= 10;
                index++;
            }

            return converted;
        }
        public static int hexaToDecimal(String h)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            char[] dig = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            int i = h.Length - 1;
            int index = 0;
            String temp = "";
            int result = 0;
            while (i >= 0)
            {
                int digit = 0;
                char c = h[i];
                for (int k = 0; k < digits.Length; k++)
                {
                    if (c == digits[k] || c == dig[k])
                        digit = k;

                }

                result += digit * (int)Math.Pow(16, index);
                temp = "";
                for (int j = 0; j < h.Length - 1; j++)
                {
                    temp += h[j];
                }
                h = temp;
                index++;
                --i;

            }


            return result;

        }




    }

}
