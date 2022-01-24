using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nubersprogram
{
    public class StopWatch
    {
        public static void ElapsedTime()
        {
            //created Object of Stopwatch class
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Hit Enter to start Watch");
            Console.ReadLine();
            stopWatch.Start();    //Timmer started.
            Thread.Sleep(6000);  //pause for 6 second
            Console.WriteLine("Hit Enter to stop Watch");
            Console.ReadLine();
            stopWatch.Stop();   //Timer stopped

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}