using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCD_HCF_app
{
    internal class LCD
    {
        public static int HCF(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        public static int LowestCommonMultiple(int num1, int num2)
        {
            return (num1 * num2 ) / HCF(num1, num2);
        }
    }
}
