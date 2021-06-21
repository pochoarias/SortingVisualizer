using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public interface ILogger
    {
        public void Init(string algorithm);
        public void Stop();
    }
}
