using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AccessModifiers
{
    internal class Point
    {
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;

        private void PrintX()
        {
            Console.WriteLine($"X: {_x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"y: {_y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }
}
