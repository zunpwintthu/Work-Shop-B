using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_B
{
    class B_4
    {
        public static void Main()
        {
            Console.Write("Enter the temperature in Centigrade : ");
            double C = Convert.ToDouble(Console.ReadLine());
            double F = 1.8 * C + 32;
            Console.WriteLine("The temperature in Fahrenheit "+ F);
        }
    }
}
