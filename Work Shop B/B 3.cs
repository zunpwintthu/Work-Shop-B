using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Shop_B
{
    class B_3
    {
        public static void Main()
        {
            Console.Write("Enter the Salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());
            double ha = (salary * 3 / 100);
            double ta = (salary * 10 / 100);
            double total = salary + ha + ta;
            Console.WriteLine("The total Income : ${0:0,000.00} " ,total );
        }
    }
}
