using System;

namespace MyCar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please press the option");
            Console.WriteLine("i/I for increase car speed");
            Console.WriteLine("d/D for decrease car speed");
            Console.WriteLine("e/E for decrease car speed");
            Console.WriteLine("l/L to lock seatbelt of car");
            Console.WriteLine("u/U to unlock seatbelt of car");


            var simulator = new CarSpeedSimulator();
            var alarm = new Alarm();
            var speedometer = new Speedometer(simulator);
            var seatBelt = new SeatBelt(speedometer, alarm);
            var speedAlarm = new SpeedAlarm(speedometer, alarm);

            while (true)
            {
                var key = Console.ReadKey();
                Console.WriteLine();
                var keyChar = key.KeyChar;
                if (keyChar == 'i' || keyChar == 'I')
                    simulator.Increase();
                else if (keyChar == 'd' || keyChar == 'D')
                    simulator.Decrease();
                else if (keyChar == 'l' || keyChar == 'L')
                    seatBelt.Lock();
                else if (keyChar == 'u' || keyChar == 'U')
                    seatBelt.Unlock();
                else if (keyChar == 'e' || keyChar == 'E') break;
            }
        }
    }
}