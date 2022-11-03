using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        private int _speed = 0;

        /// <summary>
        /// Выводим скорость автомобиля
        /// </summary>
        public void PrintSpeed()
        {
            if (_speed == 0)
            {
                Console.WriteLine("Стоим на месте...");
            }
            if (_speed > 0)
            {
                Console.WriteLine($"Едем вперед со скоростью {_speed} км/ч");
            }
            
            if (_speed < 0)
            {
                Console.WriteLine($"Едем назад со скоростью {-_speed} км/ч");
            }
        }

        public void DriveForward()
        {
            _speed = 60;
        }

        public void Stop()
        {
            _speed = 0;
        }

        public void DriveBackward()
        {
            _speed = -5;
        }

    }
}
