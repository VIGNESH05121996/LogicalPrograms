using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public void PerNum()
        {
            Console.WriteLine("Enter Starting Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Number");
            int b = Convert.ToInt32(Console.ReadLine());

            for(int i=a;i<=b;i++)
            {
                int sum = 0;
                for(int j=1;j<i;j++)
                {
                    if(i%j==0)
                    {
                        sum = sum + j;
                    }
                }
                if(sum==i)
                {
                    Console.WriteLine(+ i);
                }
            }
        }
    }
}
