using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSimulator
{
    class Program
    {
        private static string url = "http://192.168.0.10:21080/AtlantisJavaEE-war/services/mobile";
        static void Main(string[] args)
        {
            Connection connection = new Connection(url);
            //connection.sendData(httpVerb.POST, "/user/users", "{\"id\":100001,\"name\":\"TestPost\"}");

            bool doRun = true;
            while (doRun)
            {
                Console.Clear();
                Utilities.prompMenu();
                Console.WriteLine("Which device do you want to simulate ?");
                string s = Console.ReadLine();
                int choice = 2;
                while (s.Length != 1 || !int.TryParse(s, out choice) || choice > 8)
                {
                    Console.Clear();
                    Utilities.prompMenu();
                    Console.WriteLine("Please enter a valid choice");
                    s = Console.ReadLine();
                }
                Console.WriteLine("");
                int occ = 0;
                if (choice != 0)
                {
                    Console.WriteLine("How many metrics do you want to simulate ? (max 999999)");
                    s = Console.ReadLine();
                   
                    while (s.Length > 6 || !int.TryParse(s, out occ))
                    {
                        Console.Clear();
                        Utilities.prompMenu();
                        Console.WriteLine("Please enter a valid number (max 999999)");
                        s = Console.ReadLine();
                    }
                }


                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Presence Sensor");
                        Generators.GeneratePresenceSensor(occ,connection);
                        Console.WriteLine("Press anywhere to get back to the menu");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Temperature Sensor");
                        Generators.GenerateTemperatureSensor(occ,connection);
                        Console.WriteLine("Press anywhere to get back to the menu");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Light Sensor");
                        Generators.GenerateLightSensor(occ,connection);
                        Console.WriteLine("Press anywhere to get back to the menu");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Atmospheric Pressure Sensor");
                        Generators.GenerateAtmosphericPressureSensor(occ,connection);
                        Console.WriteLine("Press anywhere to get back to the menu");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Humidity Sensor");
                        Generators.GenerateHumiditySensor(occ,connection);
                        Console.WriteLine("Press anywhere to get back to the menu");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Sound Level Sensor");
                        Generators.GenerateSoundLevelSensor(occ,connection);
                        Console.WriteLine("Press anywhere to get back to the menu");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("GPS Sensor");
                        Generators.GenerateGPSSensor(occ,connection);
                        Console.WriteLine("Press anywhere to get back to the menu");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("CO2 Level Sensor");
                        Generators.GenerateCO2LevelSensor(occ,connection);
                        Console.WriteLine("Press anywhere to get back to the menu");
                        Console.ReadLine();
                        break;
                    default:
                        doRun = false;
                        break;
                }
                
            }
        }


    }
}
