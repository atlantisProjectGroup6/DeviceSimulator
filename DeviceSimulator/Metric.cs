namespace DeviceSimulator
{
    class Metric
    {
        public string mac;
        public long timestamp;
        public string value;
        public int type;
        public string name;

        public Metric(string mac, long time, string val, int type, string name)
        {
            this.mac = mac;
            this.timestamp = time;
            this.value = val;
            this.type = type;
            this.name = name;
        }
    }
}
