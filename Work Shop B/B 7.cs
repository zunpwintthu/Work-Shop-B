using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_B
{
    class B_7
    {
        public static void Main()
        {
            Console.Write("Enter the distance : ");
            double distance = Convert.ToDouble(Console.ReadLine());
            if (distance==0)
            {
                Console.WriteLine("Minimum fixed charge: 2.4");
            }
            else
            {
                double dis = 2.4 + distance * 0.4;
                Console.WriteLine("The distance traveled is" + distance + "the total fare is" + dis);
            }
        }
    }
}
