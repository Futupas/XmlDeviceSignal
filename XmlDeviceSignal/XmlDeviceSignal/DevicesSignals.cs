using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlDeviceSignal
{
    public class Device
    {
        public int id;
        public string name;
    }
    public class Signal
    {
        public int id;
        public string name;
        public List<Device> devices = new List<Device>();
    }
}
