class Program
{
    class Timer
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }

        public Timer() { }
        public Timer(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void workingTimer()
        {
            while (hours > 0 || minutes > 0 || seconds > 0)
            {
                TimeOnly t = new TimeOnly(hours, minutes, seconds);
                Console.WriteLine(t.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
                Console.Clear();

                if (seconds > 0)
                {
                    seconds--;
                }
                else if (minutes > 0)
                {
                    minutes--;
                    seconds = 59;
                }
                else if (hours > 0)
                {
                    hours--;
                    minutes = 59;
                    seconds = 59;
                }
            }

            Console.WriteLine(new TimeOnly(0, 0, 0).ToString("HH:mm:ss"));
            Console.WriteLine("Time's up!");
        }
    }
    static void Main(string[] args)
    {
        Timer t = new Timer(0, 1, 0);
        t.workingTimer();
    }
}
