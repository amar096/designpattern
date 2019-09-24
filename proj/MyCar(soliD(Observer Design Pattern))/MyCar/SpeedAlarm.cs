using System;

namespace MyCar
{
    public class SpeedAlarm
    {
        private readonly Alarm _alarm;
        private int _oldSpeed = 0;

        public SpeedAlarm(Speedometer speedometer, Alarm alarm)
        {
            _alarm = alarm;
            speedometer.SpeedChangeDelegate += OnSpeedChanged;
        }

        public void OnSpeedChanged(int speed)
        {
            if (_oldSpeed < 80 && speed >= 80) _alarm.RaiseAlarm();
            _oldSpeed = speed;
        }
    }

    //Read about UML
    //
}