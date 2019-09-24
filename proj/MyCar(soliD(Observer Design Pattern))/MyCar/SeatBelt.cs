using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyCar
{
    public class SeatBelt
    {
        private bool _isLocked = false;
        private readonly Alarm _alarm;
        public SeatBelt(Speedometer speedometer, Alarm alarm)
        {
            speedometer.SpeedChangeDelegate += OnSpeedChange;
            _alarm = alarm;
        }

        private void OnSpeedChange(int speed)
        {
            if (speed > 20 && !IsLocked)
            {
                Console.WriteLine("Please lock your Seatbelt");
                _alarm.RaiseAlarm();
            }
        }
        
        public bool IsLocked
        {
            get => _isLocked;
            private set => _isLocked = value;
        }

        public void Lock()
        {
            IsLocked = true;
            Console.WriteLine("Seatbelt Locked");
        }

        public void Unlock()
        {
            IsLocked = false;
            Console.WriteLine("Seatbelt Unlocked");
        }
    }
}