 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CoupenNumber
    {
        public void CoupNum()
        {
            Random random = new Random();
            int n = 10;
            
            for(int i=0;i<n;i++)
            {
                n = random.Next();
                Console.WriteLine(+n);
                break;
            }
          
        }
    }
}
