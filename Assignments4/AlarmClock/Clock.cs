using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    internal class Clock
    {
        public event Action<Clock> TickEvent;
        public event Action<Clock> AlarmEvent;
        public ClockTime NowTime { get; set; }
        public ClockTime AlarmTime{ get; set; }
        public bool Flag { get; set; }
        public Clock() {
            DateTime now = DateTime.Now;
            NowTime = new ClockTime(now.Hour, now.Minute, now.Second);
            TickEvent += c => Console.WriteLine(NowTime);
            AlarmEvent += c => Console.WriteLine("Alarm");
        }

        public void Run() {
            while (Flag)
            {
                DateTime now = DateTime.Now;
                while (now.Second - NowTime.Second < 1) now = DateTime.Now; ;
                NowTime = new ClockTime(now.Hour, now.Minute, now.Second);
                if (NowTime.Equals(AlarmTime)){
                    AlarmEvent(this);
                }
                TickEvent(this);
            }
        }
    }
}
