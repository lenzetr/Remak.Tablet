using System;
using System.ComponentModel;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Remak.Tablet.UI.Helpers
{
    public class Background
    {
        private readonly object _lockObject = new object();
        private BackgroundWorker _bgWorker;
        private Timer _tmrCallBgWorker;
        private System.Threading.Timer _tmrEnsureWorkerGetsCalled;

        public Background(Action method)
        {
            MethodToCall = method;
        }

        public Action MethodToCall { get; set; }

        public void Initialize(int time)
        {
            _tmrCallBgWorker = new Timer();
            _tmrCallBgWorker.Tick += tmrCallBgWorker_Tick;
            _tmrCallBgWorker.Interval = time;

            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += bg_DoWork;
            _bgWorker.RunWorkerCompleted += bg_RunWorkerCompleted;
        }

        public void Start()
        {
            _tmrCallBgWorker.Start();
        }

        public void Stop()
        {
            _tmrCallBgWorker.Stop();
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Complete");
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            MethodToCall.Invoke();
        }

        private void tmrCallBgWorker_Tick(object sender, EventArgs e)
        {
            if (Monitor.TryEnter(_lockObject))
                try
                {
                    // if bgworker is not busy the call the worker
                    if (!_bgWorker.IsBusy)
                        _bgWorker.RunWorkerAsync();
                }
                finally
                {
                    Monitor.Exit(_lockObject);
                }
            else
                // as the bgworker is busy we will start a timer that will try to call the bgworker again after some time
                _tmrEnsureWorkerGetsCalled =
                    new System.Threading.Timer(tmrEnsureWorkerGetsCalled_Callback, null, 0, 10);
        }

        private void tmrEnsureWorkerGetsCalled_Callback(object obj)
        {
            // this timer was started as the bgworker was busy before now it will try to call the bgworker again
            if (Monitor.TryEnter(_lockObject))
            {
                try
                {
                    if (!_bgWorker.IsBusy)
                        _bgWorker.RunWorkerAsync();
                }
                finally
                {
                    Monitor.Exit(_lockObject);
                }

                _tmrEnsureWorkerGetsCalled = null;
            }
        }
    }
}