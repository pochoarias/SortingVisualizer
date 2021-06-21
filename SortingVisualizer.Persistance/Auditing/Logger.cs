using SortingVisualizer.Persistance.Auditing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class Logger : ILogger
    {
        private readonly ITimer _timer;

        public Logger(ITimer timer)
        {
            _timer = timer ?? throw new ArgumentNullException(nameof(timer)); 
        }

        public void Init(string algorithm)
        {
            Console.WriteLine($"Sorting using: {algorithm}");
            _timer.LogStart();
        }

        public void Stop()
        {
            Console.WriteLine($"End sorting");
            _timer.LogEnd();
            Console.WriteLine("Time taken: " + _timer.ElapsedMilliseconds() + "ms");
        }
    }
}
