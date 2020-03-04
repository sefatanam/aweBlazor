using System;
using System.Timers;

namespace AweBlazor.Service
{
    public class TimeService
    {
        private Timer _timer;

        public void SetTimer(double interval)
        {
            _timer = new Timer(interval);
            _timer.Elapsed += NotifyTimerElapsed;
            _timer.Enabled = true;
        }

        public event Action OnElapsed;

        private void NotifyTimerElapsed(Object source, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
            _timer.Dispose();
        }
    }
}
