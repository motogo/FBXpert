using System.ComponentModel;
using System.Diagnostics;

namespace FBXpert.Globals
{
    class WorkerClass : BackgroundWorker
    {
        public bool CancelGettingData(int timeout = 2000)
        {
            if (!this.IsBusy) return true;
            this.CancelAsync();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (this.CancellationPending)
            {
                if (sw.ElapsedMilliseconds > timeout)
                {
                    sw.Stop();
                    return false;
                }
            }
            sw.Stop();
            return true;
        }
        public bool CancellingDone(int timeout = 5000)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (this.CancellationPending || this.IsBusy)
            {
                if (sw.ElapsedMilliseconds > timeout)
                {
                    sw.Stop();
                    return false;
                }
            }
            sw.Stop();
            return true;
        }
    }
}
