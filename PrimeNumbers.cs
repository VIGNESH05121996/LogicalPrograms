using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PrimeNumbers
    {
        public void PriNum()
        {
            Console.WriteLine("Enter Starting Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Number");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                int prime = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime++;
                    }
                }
                if (prime == 0 && i!=1 )
                {
                    Console.WriteLine(+i);
                }
            }
        }
    }
}
