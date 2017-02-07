using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_B
{
    class B_6
    {
        public static void Main()
        {
            Console.WriteLine("Enter the x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double distance=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            //double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2-y1) * (y2 - y1));
            Console.WriteLine("Distance "+ distance);
        }
    }
}
