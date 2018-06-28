using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeviceSimulator
{
    static class Generators
    {
        //DATA SENT :
        //MAC
        //VALUE
        //DATE

        public static void GeneratePresenceSensor(int occ)
        {
            for (int i = 0; i < occ; i++)
            {
                var mac = GenerateMACAddress(i);
                var date = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
                var r = new Random(i);
                var value = r.Next(0, 2) == 1;
                //Thread.Sleep(1000);
                Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + date + " - Value = " + value);
            }
        }

        public static void GenerateTemperatureSensor(int occ)
        {
            for (int i = 0; i < occ; i++)
            {
                var mac = GenerateMACAddress(i);
                var date = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
                var r = new Random(i);
                var value = Math.Round((-10 + r.NextDouble() * 50),1);
                //Thread.Sleep(1000);
                Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + date + " - Value = " + value);
            }
        }

        public static void GenerateLightSensor(int occ)
        {
            for (int i = 0; i < occ; i++)
            {
                var mac = GenerateMACAddress(i);
                var date = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
                var r = new Random(i);
                var value = r.Next(0,1001);
                //Thread.Sleep(1000);
                Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + date + " - Value = " + value);
            }
        }

        public static void GenerateAtmosphericPressureSensor(int occ)
        {
            for (int i = 0; i < occ; i++)
            {
                var mac = GenerateMACAddress(i);
                var date = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
                var r = new Random(i);
                var value = Math.Round((95 + r.NextDouble() * 11),2);
                //Thread.Sleep(1000);
                Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + date + " - Value = " + value);
            }
        }

        public static void GenerateHumiditySensor(int occ)
        {
            for (int i = 0; i < occ; i++)
            {
                var mac = GenerateMACAddress(i);
                var date = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
                var r = new Random(i);
                var value = Math.Round((r.NextDouble() * 100),2);
                //Thread.Sleep(1000);
                Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + date + " - Value = " + value);
            }
        }

        public static void GenerateSoundLevelSensor(int occ)
        {
            for (int i = 0; i < occ; i++)
            {
                var mac = GenerateMACAddress(i);
                var date = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
                var r = new Random(i);
                var value = r.Next(0,160);
                //Thread.Sleep(1000);
                Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + date + " - Value = " + value);
            }
        }
        public static void GenerateGPSSensor(int occ)
        {
            for (int i = 0; i < occ; i++)
            {
                var mac = GenerateMACAddress(i);
                var date = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
                var r = new Random(i);
                var CoordNS = r.Next(0, 2) == 1 ? "N":"S";
                var CoordLatA = r.Next(0,90);
                var CoordLatB = r.Next(0,60);
                var CoordLatC = Math.Round(r.NextDouble()*60,4);
                var CoordEW = r.Next(0, 2) == 1 ? "E" : "W";
                var CoordLongA = r.Next(0, 180);
                var CoordLongB = r.Next(0, 60);
                var CoordLongC = Math.Round(r.NextDouble() * 60, 4);
                var value = new StringBuilder().Append(CoordNS).Append(CoordLatA + "°").Append(CoordLatB + "\'").Append(CoordLatC + "\" ").Append(CoordEW).Append(CoordLongA + "°").Append(CoordLongB + "\'").Append(CoordLongC + "\"");
                //Thread.Sleep(1000);
                Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + date + " - Value = " + value);
            }
        }

        public static void GenerateCO2LevelSensor(int occ)
        {
            for (int i = 0; i < occ; i++)
            {
                var mac = GenerateMACAddress(i);
                var date = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
                var r = new Random(i);
                var value = Math.Round((408 + r.NextDouble() * 7),2);
                //Thread.Sleep(1000);
                Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + date + " - Value = " + value);
            }
        }

        public static string GenerateMACAddress(int id)
        {
            var sBuilder = new StringBuilder();
            var r = new Random(id);
            int number;
            byte b;
            for (int i = 0; i < 6; i++)
            {
                number = r.Next(0, 255);
                b = Convert.ToByte(number);
                if (i == 0)
                {
                    b = setBit(b, 6);
                    b = unsetBit(b, 7);
                }
                sBuilder.Append(number.ToString("X2"));
            }
            return sBuilder.ToString().ToUpper().Insert(10, ":").Insert(8, ":").Insert(6, ":").Insert(4, ":").Insert(2, ":");
        }
        private static byte setBit(byte b, int BitNumber)
        {
            if (BitNumber < 8 && BitNumber > -1)
            {
                return (byte)(b | (byte)(0x01 << BitNumber));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        private static byte unsetBit(byte b, int BitNumber)
        {
            if (BitNumber < 8 && BitNumber > -1)
            {
                return (byte)(b | (byte)(0x00 << BitNumber));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
