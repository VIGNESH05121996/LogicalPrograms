using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class FiboSeries
    {
        public void FibSeries()
        {
            int a = 0, b = 1,temp;
            
            Console.WriteLine("Enter Number Of Times To Execute FibonacciSeries");
            int  n = Convert.ToInt32(Console.ReadLine());

            for (int i = 3; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(+ temp);
            }

           
        }
    }
}
