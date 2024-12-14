using System;
using System.Timers;
using static ls1_5_class.Trade;


namespace ls1_5_class
{
    public class Position
    {
        private static System.Timers.Timer _timer;

        public Position()
        {
            SetTimer();
            Console.ReadLine();
            _timer.Stop();
            _timer.Dispose();
        }

        private void SetTimer()
        {
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);

            _timer = new System.Timers.Timer(3000);
            _timer.Elapsed += createNewPosition;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private void createNewPosition(Object source, ElapsedEventArgs e)
        {
            Trade trade = new Trade();
            Random random = new Random();

            trade.Direction = (__directions)Math.Sign(random.Next(-10, 10));
            trade.Security = (__securities)random.Next(0, 4);

            trade.Volume = random.Next(0, 100);
            trade.Price = random.Next(70000,80000);

            string str = "Volume: " + trade.Volume.ToString() + "; Level: " + trade.Price.ToString() + "; Direction: " + trade.Direction + "; Security: " + trade.Security;
            Console.WriteLine(str);
        }
    }
}
