using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer.Persistance.Auditing
{
    public class Timer : ITimer
    {
        public Timer()
        {
            Stopwatch = new Stopwatch();
        }

        public Stopwatch Stopwatch { get; set; }

        public long ElapsedMilliseconds()
        {
            return Stopwatch.ElapsedMilliseconds;
        }

        public void LogEnd()
        {
            Stopwatch.Stop();
        }

        public void LogStart()
        {
            Stopwatch.Reset();
            Stopwatch.Start();
        }
    }
}
