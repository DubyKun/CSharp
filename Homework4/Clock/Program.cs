using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public delegate void TickHandler(object sender, TimeArgs args);

    public class TimeArgs
    {
        public int Hour;
        public int Minute;
        public int Second;
        public class Clock
        {
            private int hour, minute, second, aHour, aMinute, aSecond;
            public event TickHandler Tick;
            public event TickHandler Alarm;
            public Clock(int hour, int minute)
            {
                if (hour < 60 && minute < 60)
                {
                    this.hour = hour;
                    this.minute = minute;
                    this.second = 0;
                }
                else
                    this.hour = this.minute = this.second = 0;
            }
            public void SetClock(int hour, int minute,int second)
            {
                aHour = hour;
                aMinute = minute;
                aSecond = second;
            }
            public void Run()
            {
                while (true)
                {
                    if (this.second < 59) this.second++;
                    else
                    {
                        this.second = 0;
                        this.minute++;
                        if (this.minute == 60)
                        {
                            this.minute = 0;
                            this.hour = (this.hour + 1) % 24;
                        }
                    }
                    TimeArgs CurrentTime = new TimeArgs()  { Hour = hour, Minute = minute, Second = second };
                    if (this.hour == this.aHour && this.minute == this.aMinute && this.second == this.aSecond)
                    {
                        Alarm(this, CurrentTime);
                    }
                    else
                    {
                        Tick(this, CurrentTime);
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        public class MyClock
        {
            public Clock myClock;
            public MyClock(int hour, int minute)
            {
                myClock = new Clock(hour, minute);
                myClock.Tick += OnTick;
                myClock.Alarm += OnAlarm;
            }
            void OnTick(object sender, TimeArgs args)
            {
                Console.WriteLine("Tick!：[" + args.Hour + ":" + args.Minute + ":" + args.Second + "]");
            }
            void OnAlarm(object sender, TimeArgs args)
            {
                Console.WriteLine("Alarm!：[" + args.Hour + ":" + args.Minute + ":" + args.Second + "]");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                MyClock myClock = new MyClock(7, 0);
                myClock.myClock.SetClock(7, 0,1);
                myClock.myClock.Run();
            }
        }
    }
}

