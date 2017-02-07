using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_B
{
    class B_5
    {
        public static void Main()
        {
            Console.Write("Enter the number x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 5 * x * x -4 * x + 3;
            Console.WriteLine("The output value of y is  "+ y);
        }
    }
}
