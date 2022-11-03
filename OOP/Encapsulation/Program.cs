using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    //          Инкапсуляция
    //          Конструктор класса
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: false);
            gun.Shoot();
        }
    }
}
