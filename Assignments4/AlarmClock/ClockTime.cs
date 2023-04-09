using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    internal class ClockTime
    { 
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public ClockTime(int hour = 0, int minute = 0, int second = 0)
        {
            if (hour > 0 && minute >= 0 && second >= 0 && hour < 24 && minute < 60 && second < 60)
            {
                this.Hour = hour;
                this.Minute = minute;
                this.Second = second;
            }
            else
            {
                this.Hour = 0;
                this.Minute = 0;
                this.Second = 0;
            }
        }
        public override bool Equals(Object obj)
        {
            var clocktime = obj as ClockTime;
            if (clocktime == null)
            {
                return false;
            }
            return this.Second == clocktime.Second && this.Hour == clocktime.Hour && this.Minute == clocktime.Minute;
        }
        public override string ToString()
        {
            return "Time:"+Hour + ":" + Minute + ":" + Second;
        }
    }
}
