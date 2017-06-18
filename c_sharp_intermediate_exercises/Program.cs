using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c_sharp_intermediate_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            int milliseconds = 2000;

            stopWatch.Start();
            Thread.Sleep(milliseconds);
            stopWatch.Stop();

            Console.WriteLine("Elapsed Time: " + stopWatch.ElapsedTime);

            stopWatch.Start();
            Thread.Sleep(milliseconds);
            stopWatch.Stop();

            Console.WriteLine("Elapsed Time: " + stopWatch.ElapsedTime);

            // Will throw exception because we tried to start it twice.
            stopWatch.Start();
            stopWatch.Start();

        }
    }
}
