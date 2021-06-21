using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer.Persistance.Auditing
{
    public interface ITimer
    {
        public Stopwatch Stopwatch { get; set; }
        public void LogStart();
        public void LogEnd();
        public long ElapsedMilliseconds();

    }
}
