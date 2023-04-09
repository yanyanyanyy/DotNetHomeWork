using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.Flag = true; //循环控制的标志
            DateTime now = DateTime.Now;
            clock.AlarmTime = new ClockTime(now.Hour, now.Minute+(now.Second+10)/60, (now.Second+10)%60);
            clock.Run();
        }
    }
}
