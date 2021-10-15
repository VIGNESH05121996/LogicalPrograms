using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Fibonacci Series\t\t2: Perfect Numbers");
            Console.WriteLine("3: Prime Numbers\t\t4: Reverse Numbers");
            Console.Write("5: Coupen Numbers\t\t6: Simulate Stop Watch Program");

            Console.WriteLine("\nEnter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    FiboSeries fib = new FiboSeries();
                    fib.FibSeries();
                    break;

                case 2:
                    PerfectNumber pn = new PerfectNumber();
                    pn.PerNum();
                    break;

                case 3:
                    PrimeNumbers prn = new PrimeNumbers();
                    prn.PriNum();
                    break;

                case 4:
                    ReverseANum rnum = new ReverseANum();
                    rnum.RevNum();
                    break;

                case 5:
                    CoupenNumber cn = new CoupenNumber();
                    cn.CoupNum();
                    break;

                case 6:
                    StopWatchSimulate stp = new StopWatchSimulate();
                    stp.StWatch();
                    break;

                default:
                    Console.WriteLine("Entered Choice Not Within Range");
                    break;

            }

            
        }
    }
}
