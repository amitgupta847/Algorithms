using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataStructureAndAlgorithms.UI
{
    /// <summary>
    /// Interaction logic for Clock.xaml
    /// </summary>
    public partial class Clock : UserControl
    {
        Thread theMainThread;
        ThreadStart ts;
        AutoResetEvent _autoSemaphore;


        private Stopwatch theStopWatch;
        public Stopwatch StopWatchAlgo
        {
            get
            {
                if (theStopWatch == null)
                {
                    theStopWatch = new Stopwatch();
                }

                return theStopWatch;
            }
            private set { theStopWatch = value; }
        }

        public Clock()
        {
            InitializeComponent();
            _autoSemaphore = new AutoResetEvent(false);
            ts = new ThreadStart(ExpansiveMethod);
            theMainThread = new Thread(ts);
            theMainThread.Start();
        }

        bool isStarted = true;
        bool _stopProcessing = false;

        protected void ExpansiveMethod()
        {
            Action act = new Action(UpdateChange);

            while (!_stopProcessing)
            {
                WaitHandle.WaitAny(new WaitHandle[] { _autoSemaphore });

                if (!StopWatchAlgo.IsRunning)
                {
                    StopWatchAlgo.Start();
                }

                while (isStarted)
                {
                    this.Dispatcher.BeginInvoke(act);
                    Thread.Sleep(100);
                }
                StopWatchAlgo.Stop();
            }
        }

        protected void UpdateChange()
        {
            lblCounter.Content = StopWatchAlgo.Elapsed.Milliseconds / 100;
            lblSec.Content = StopWatchAlgo.Elapsed.Seconds;
            lblMinute.Content = StopWatchAlgo.Elapsed.Minutes;
        }

        private void btnStartClick(object sender, RoutedEventArgs e)
        {
            if ((string)(btnStart.Content) == "Start")
            {
                StartWatch();
                btnStart.Content = "Stop";
            }
            else
            {
                Stopwatch();
                btnStart.Content = "Start";
            }
        }

        private void StartWatch()
        {
            isStarted = true;
            _autoSemaphore.Set();
        }

        private void Stopwatch()
        {
            isStarted = false;
        }

        private void btnResetClick(object sender, RoutedEventArgs e)
        {
            StopWatchAlgo.Reset();
            UpdateReset();
        }

        private void UpdateReset()
        {
            lblCounter.Content = 0;
            lblSec.Content = 00;
            lblMinute.Content = 00;
        }

        public void Start(Stopwatch stopwatch)
        {
            StopWatchAlgo = stopwatch;
            StartWatch();
        }

        public void Stop()
        {
            Stopwatch();
        }

        //        //delegate for our method of type void
        //public delegate void Process();
        ////and then use the dispatcher to call the method. 
        //Process del = new Process(UpdateMyUI);
        //this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Background, del);
        //void UpdateMyUI()
        //{
        ////get back to main UI thread
        //}

        ~Clock()
        {
            if (_autoSemaphore != null)
            {
                _autoSemaphore.Close();
            }
        }
    }
}
