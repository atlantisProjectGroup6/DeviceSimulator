using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSimulator
{
    static class Utilities
    {
        public static void prompMenu()
        {
            Console.WriteLine("-----------\t Device Simulator \t-----------");
            Console.WriteLine("1 - Presence Sensor");
            Console.WriteLine("2 - Temperature Sensor");
            Console.WriteLine("3 - Light Sensor");
            Console.WriteLine("4 - Atmospheric Pressure Sensor");
            Console.WriteLine("5 - Humidity Sensor");
            Console.WriteLine("6 - Sound Level Sensor");
            Console.WriteLine("7 - GPS Sensor");
            Console.WriteLine("8 - CO2 Level Sensor");
            Console.WriteLine("");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("");
        }
    }
}
