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
        public static void GeneratePresenceSensor(int occ, Connection connection)
        {
            List<Metric> metrics = new List<Metric>();
            for (int i = 0; i < occ; i++)
            {
                var r = new Random(i);
                var timestamp = Math.Floor((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
                var mac = Utilities.macsPresence.ElementAt(r.Next(0, Utilities.macsPresence.Count)).Key;
                var name = Utilities.macsPresence.ElementAt(r.Next(0, Utilities.macsPresence.Count)).Value;
                var value = r.Next(0, 2) == 1 ? true : false;
                metrics.Add(new Metric(mac, (long)timestamp, value.ToString(), 1, name));
                //Thread.Sleep(1000);
                //Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + timestamp + " - Value = " + value + " - Type = 1 - Name = " + name);
            }
            formatListToJson(metrics, connection, 1);
        }

        public static void GenerateTemperatureSensor(int occ, Connection connection)
        {
            List<Metric> metrics = new List<Metric>();
            for (int i = 0; i < occ; i++)
            {
                var r = new Random(i);
                var timestamp = Math.Floor((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
                var mac = Utilities.macsTemperature.ElementAt(r.Next(0, Utilities.macsTemperature.Count)).Key;
                var name = Utilities.macsTemperature.ElementAt(r.Next(0, Utilities.macsTemperature.Count)).Value;
                var value = Math.Round((-10 + r.NextDouble() * 50), 1);
                metrics.Add(new Metric(mac, (long)timestamp, value.ToString(), 2, name));
                //Thread.Sleep(1000);
                //Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + timestamp + " - Value = " + value + " - Type = 2");
            }
            formatListToJson(metrics, connection, 2);
        }

        public static void GenerateLightSensor(int occ, Connection connection)
        {
            List<Metric> metrics = new List<Metric>();
            for (int i = 0; i < occ; i++)
            {
                var r = new Random(i);
                var timestamp = Math.Floor((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
                var mac = Utilities.macsLight.ElementAt(r.Next(0, Utilities.macsLight.Count)).Key;
                var name = Utilities.macsLight.ElementAt(r.Next(0, Utilities.macsLight.Count)).Value;
                var value = r.Next(0, 1001);
                metrics.Add(new Metric(mac, (long)timestamp, value.ToString(), 3, name));
                //Thread.Sleep(1000);
                //Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + timestamp + " - Value = " + value + " - Type = 3");
            }
            formatListToJson(metrics, connection, 3);
        }

        public static void GenerateAtmosphericPressureSensor(int occ, Connection connection)
        {
            List<Metric> metrics = new List<Metric>();
            for (int i = 0; i < occ; i++)
            {
                var r = new Random(i);
                var timestamp = Math.Floor((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
                var mac = Utilities.macsAtmosphericPresssure.ElementAt(r.Next(0, Utilities.macsAtmosphericPresssure.Count)).Key;
                var name = Utilities.macsAtmosphericPresssure.ElementAt(r.Next(0, Utilities.macsAtmosphericPresssure.Count)).Value;
                var value = Math.Round((95 + r.NextDouble() * 11), 2);
                metrics.Add(new Metric(mac, (long)timestamp, value.ToString(), 4, name));
                //Thread.Sleep(1000);
                //Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + timestamp + " - Value = " + value + " - Type = 4");
            }
            formatListToJson(metrics, connection, 4);
        }

        public static void GenerateHumiditySensor(int occ, Connection connection)
        {
            List<Metric> metrics = new List<Metric>();
            for (int i = 0; i < occ; i++)
            {
                var r = new Random(i);
                var timestamp = Math.Floor((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
                var mac = Utilities.macsHumidity.ElementAt(r.Next(0, Utilities.macsHumidity.Count)).Key;
                var name = Utilities.macsHumidity.ElementAt(r.Next(0, Utilities.macsHumidity.Count)).Value;
                var value = Math.Round((r.NextDouble() * 100), 2);
                metrics.Add(new Metric(mac, (long)timestamp, value.ToString(), 5, name));
                //Thread.Sleep(1000);
                //Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + timestamp + " - Value = " + value + " - Type = 5");
            }
            formatListToJson(metrics, connection, 5);
        }

        public static void GenerateSoundLevelSensor(int occ, Connection connection)
        {
            List<Metric> metrics = new List<Metric>();
            for (int i = 0; i < occ; i++)
            {
                var r = new Random(i);
                var timestamp = Math.Floor((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
                var mac = Utilities.macsSoundLevel.ElementAt(r.Next(0, Utilities.macsSoundLevel.Count)).Key;
                var name = Utilities.macsSoundLevel.ElementAt(r.Next(0, Utilities.macsSoundLevel.Count)).Value;
                var value = r.Next(0, 160);
                metrics.Add(new Metric(mac, (long)timestamp, value.ToString(), 6, name));
                //Thread.Sleep(1000);
                //Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + timestamp + " - Value = " + value + " - Type = 6");
            }
            formatListToJson(metrics, connection, 6);
        }
        public static void GenerateGPSSensor(int occ, Connection connection)
        {
            List<Metric> metrics = new List<Metric>();
            for (int i = 0; i < occ; i++)
            {
                var r = new Random(i);
                var timestamp = Math.Floor((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
                var mac = Utilities.macsGps.ElementAt(r.Next(0, Utilities.macsGps.Count)).Key;
                var name = Utilities.macsGps.ElementAt(r.Next(0, Utilities.macsGps.Count)).Value;
                var CoordNS = r.Next(0, 2) == 1 ? "N" : "S";
                var CoordLatA = r.Next(0, 90);
                var CoordLatB = r.Next(0, 60);
                var CoordLatC = Math.Round(r.NextDouble() * 60, 4);
                var CoordEW = r.Next(0, 2) == 1 ? "E" : "W";
                var CoordLongA = r.Next(0, 180);
                var CoordLongB = r.Next(0, 60);
                var CoordLongC = Math.Round(r.NextDouble() * 60, 4);
                var value = new StringBuilder().Append(CoordNS).Append(CoordLatA + "°").Append(CoordLatB + "\'").Append(CoordLatC + "\'' ").Append(CoordEW).Append(CoordLongA + "°").Append(CoordLongB + "\'").Append(CoordLongC + "\''");
                metrics.Add(new Metric(mac, (long)timestamp, value.ToString(), 7, name));
                //Thread.Sleep(1000);
                //Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + timestamp + " - Value = " + value + " - Type = 7");
            }
            formatListToJson(metrics, connection, 7);
        }

        public static void GenerateCO2LevelSensor(int occ, Connection connection)
        {
            List<Metric> metrics = new List<Metric>();
            for (int i = 0; i < occ; i++)
            {
                var r = new Random(i);
                var timestamp = Math.Floor((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
                var mac = Utilities.macsCo2Level.ElementAt(r.Next(0, Utilities.macsCo2Level.Count)).Key;
                var name = Utilities.macsCo2Level.ElementAt(r.Next(0, Utilities.macsCo2Level.Count)).Value;
                var value = Math.Round((408 + r.NextDouble() * 7), 2);
                metrics.Add(new Metric(mac, (long)timestamp, value.ToString(), 8, name));
                //Thread.Sleep(1000);
                //Console.WriteLine("Simulation " + i + " : Mac = " + mac + " - Timestamp = " + timestamp + " - Value = " + value + " - Type = 8");
            }
            formatListToJson(metrics, connection, 8);
        }

        /*
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
        */
        private static void formatListToJson(List<Metric> metrics, Connection connection, int type)
        {
            StringBuilder json = new StringBuilder();
            for (int i = 0; i < metrics.Count; i++)
            {
                json.Append("{\"mac\":\"" + metrics.ToArray()[i].mac + "\",\"timestamp\":" + metrics.ToArray()[i].timestamp + ",\"value\":\"" + metrics.ToArray()[i].value + "\",\"type\":" + type + ",\"name\":\"" + metrics.ToArray()[i].name + "\"}");

                Console.WriteLine(json);
                Thread.Sleep(500);
                Task.Run(() => connection.sendData(httpVerb.POST, "/addMetric", json.ToString()));

                json.Clear();
            }
        }
    }
}
