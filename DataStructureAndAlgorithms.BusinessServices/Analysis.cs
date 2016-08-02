using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class Analysis
    {
        public Analysis() { }

        public Analysis(bool isStart) { theStopWatch.Start(); }

        private Stopwatch theStopWatch = new Stopwatch();

        public void Start()
        {
            theStopWatch.Start();
        }

        public void Stop()
        {
            theStopWatch.Stop();
        }


        public int NumberOfComparison { get; set; }

        public string Complexity { get; set; }


        public double ElapsedTime
        {
            get
            {
                return theStopWatch.Elapsed.TotalMilliseconds;
            }
        }
    }
}
