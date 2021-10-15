 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseANum
    {
        public void RevNum()
        {
            Console.WriteLine("Enter Any 4 Digit or 5 Digit Number To Reverse");
            int n = Convert.ToInt32(Console.ReadLine());

            int rev = 0;
            
            while(n>0)
            {
                int rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse Number Is " + rev);
        }
    }
}
