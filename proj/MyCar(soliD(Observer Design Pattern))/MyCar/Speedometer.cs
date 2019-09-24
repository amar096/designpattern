using System;

namespace MyCar
{
    public class Speedometer
    {
        private readonly SpeedAlarm _alarm;
        public Action<int> SpeedChangeDelegate;
        public Speedometer(CarSpeedSimulator speedSimulator)
        {
            speedSimulator.SpeedChanged += OnSpeedChanged;
        }

        private void OnSpeedChanged(int speed)
        {
            Console.WriteLine("Current Speed :" + speed);
            SpeedChangeDelegate?.Invoke(speed);
            //_alarm.ProcessSpeed(speed);
        }
    }
}