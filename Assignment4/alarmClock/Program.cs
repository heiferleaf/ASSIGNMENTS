using System;

//使用事件机制，模拟实现一个闹钟功能。
//闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台显示提示信息

namespace HW4.alarmClock
{
    class ClockEventArgs : EventArgs
    {
        internal int Second { get; set; }
        internal int Minute { get; set; }
        internal int Clock { get; set; }

        public ClockEventArgs(int Second, int Minute, int Clock)
        {
            this.Second = Second;
            this.Minute = Minute;
            this.Clock = Clock;
        }

    }

    class ClockPublish
    {
        public event EventHandler<ClockEventArgs> clockEvent;

        public void sendMessage(int Second, int Minute, int Clock)
        {
            clockEvent?.Invoke(this, new ClockEventArgs(Second, Minute, Clock));
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            ClockPublish cp = new ClockPublish();

            int setSecond = 0, setMinute = 0, setClock = 0;
            try
            {
                setSecond = int.Parse(Console.ReadLine());
                setMinute = int.Parse(Console.ReadLine());
                setClock = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入无效，请输入一个有效的整数。");
            }

            // 增加时钟滴答功能
            cp.clockEvent += (sender, clock) =>
                Console.WriteLine($"滴答， 当前是北京时间 {clock.Clock} 时 {clock.Minute} 分 {clock.Second} 秒");
            // 响铃功能
            cp.clockEvent += (sender, clock) =>
                Console.WriteLine((clock.Clock == setClock && clock.Minute == setMinute && clock.Second == setSecond) ? "闹钟响起" : " ");

            for (int c = 0; c < 24; c++)
                for (int m = 0; m < 60; m++)
                    for (int s = 0; s < 60; s++)
                    {
                        cp.sendMessage(s, m, c);
                    }
        }
    }
}