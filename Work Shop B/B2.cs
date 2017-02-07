using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_B
{
    class B2
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            double no = Math.Sqrt(num);
            Console.WriteLine("The square root of the number : {0:0.000} " ,no);
        }
    }
}
