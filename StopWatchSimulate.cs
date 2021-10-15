 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace LogicalPrograms
{
    class StopWatchSimulate
    {
        public void StWatch()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for(int i=0;i<10;i++)
            {
                Thread.Sleep(1000);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elspasedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime  " + elspasedTime);
        }
    }
}
