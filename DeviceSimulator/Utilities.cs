using System;
using System.Collections.Generic;

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

        public static Dictionary<string, string> macsPresence = new Dictionary<string, string>() {
            {"B9:D0:C3:8E:34:8E","Presence sensor corridor"},
            {"3F:1C:77:C4:A7:6E","Presence sensor elevator"},
            {"C4:67:2A:FB:1B:4E","Presence sensor meeting room"},
            {"4A:B1:DC:32:8E:2E","Presence sensor garage"}
        };
        public static Dictionary<string, string> macsTemperature = new Dictionary<string, string>() {
            {"D0:FC:8F:69:03:0D","Thermometer corridor"},
            {"56:48:43:9F:76:EC","Thermometer elevator"},
            {"DB:93:F5:D5:E9:CC","Thermometer meeting room"},
            {"61:DE:A8:0D:5D:AC","Thermometer garage"}
        };
        public static Dictionary<string, string> macsLight = new Dictionary<string, string>() {
            {"E6:29:5B:43:D0:8C","Light sensor corridor"},
            {"6D:74:0F:7A:44:6C","Light sensor elevator"},
            {"F2:BF:C1:B0:B7:4B","Light sensor meeting room"},
            {"78:0B:74:E7:2B:2B","Light sensor garage"}
        };
        public static Dictionary<string, string> macsAtmosphericPresssure = new Dictionary<string, string>() {
            {"FD:56:27:1E:9F:0B","Atmospheric pressure sensor corridor"},
            {"84:A1:D9:54:13:EA","Atmospheric pressure sensor elevator"},
            {"0A:EB:8D:8B:86:CA","Atmospheric pressure sensor meeting room"},
            {"8F:37:40:C1:F9:AA","Atmospheric pressure sensor garage"}
        };
        public static Dictionary<string, string> macsHumidity = new Dictionary<string, string>() {
            {"15:82:F2:F8:6D:8A","Humidity sensor corridor"},
            {"9A:CD:A5:2F:E0:69","Humidity sensor elevator"},
            {"21:19:59:66:54:49","Humidity sensor meeting room"},
            {"A6:64:0C:9C:C7:29","Humidity sensor garage"}
        };
        public static Dictionary<string, string> macsSoundLevel = new Dictionary<string, string>() {
            {"2C:AE:BE:D2:3C:09","Sound level sensor corridor"},
            {"B1:F9:71:0A:AF:E8","Sound level sensor elevator"},
            {"37:45:25:40:23:C8","Sound level sensor meeting room"},
            {"BD:90:D7:77:96:A7","Sound level sensor garage"}
        };
        public static Dictionary<string, string> macsGps = new Dictionary<string, string>() {
            {"43:DB:8A:AD:0A:87","Gps sensor car 1"},
            {"C8:26:3D:E4:7D:67","Gps sensor car 2"},
            {"4E:71:F0:1B:F0:47","Gps sensor car 3"},
            {"D4:BC:A3:51:65:27","Gps sensor car 4"}
        };
        public static Dictionary<string, string> macsCo2Level = new Dictionary<string, string>() {
            {"5A:08:56:88:D8:07","Co2 level sensor corridor"},
            {"DF:53:09:BE:4C:E5","Co2 level sensor elevator"},
            {"65:9E:BC:F5:BF:C5","Co2 level sensor meeting room"},
            {"EA:E8:6F:2C:33:A5","Co2 level sensor garage"}
        };
    }
}
