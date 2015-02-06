namespace Timer
{
    using System;
    using System.Threading;
    class AsynTimer
    {
        private int repeat;
        private int timeInterval;
        private Action<string> action;

        public AsynTimer(Action<string> action, int ticks, int time)
        {
            this.repeat = ticks;
            this.action = action;
            this.timeInterval = time;
        }

        private void Action()
        {
            for (int i = this.repeat; i >0; i--)
            {
                Thread.Sleep(this.timeInterval);

                if (action != null)
                {
                    action("");
                }

                this.repeat--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.Action);
            thread.Start();
        }
    }

}
