using System;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace Filler
{
    public partial class Form1 : Form
    {
        static string[] randomStrings = new string[] { "Lorem", "Ipsum", "Dolor", "Sit", "Amet", "Consectetur", "Adipiscing", "Elit", "Suspendisse", "Cursus" };
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DEVICES
            List<Device> devices = new List<Device>();
            int count = trackBar1.Value;
            for (int i = 1; i <= count; i++)
            {
                int id = i;
                string name = "Device " + randomStrings[i % 10] + " " + i.ToString();
                Device d = new Device();
                d.id = id;
                d.name = name;
                devices.Add(d);
            }

            XmlDocument xml = new XmlDocument();
            XmlElement xRoot = xml.CreateElement("devices");
            xml.AppendChild(xRoot);

            foreach (var d in devices)
            {
                XmlElement dev = xml.CreateElement("device");
                dev.SetAttribute("id", d.id.ToString());
                dev.SetAttribute("name", d.name);
                xRoot.AppendChild(dev);
            }

            saveFileDialog1.FileName = "devices.xml";
            string filename;
            var res = saveFileDialog1.ShowDialog();
            if (res != DialogResult.OK) return;
            filename = saveFileDialog1.FileName;

            xml.Save(filename);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SIGNALS
            List<Signal> signals = new List<Signal>();
            int count = trackBar1.Value;
            for (int i = 1; i <= count; i++)
            {
                int id = i;
                string name = "Signal " + randomStrings[i % 10] + " " + i.ToString();
                Signal s = new Signal();
                s.id = id;
                s.name = name;
                signals.Add(s);
            }

            XmlDocument xml = new XmlDocument();
            XmlElement xRoot = xml.CreateElement("signals");
            xml.AppendChild(xRoot);

            foreach (var s in signals)
            {
                XmlElement sig = xml.CreateElement("signal");
                sig.SetAttribute("id", s.id.ToString());
                sig.SetAttribute("name", s.name);
                xRoot.AppendChild(sig);
            }

            saveFileDialog1.FileName = "signals.xml";
            string filename;
            var res = saveFileDialog1.ShowDialog();
            if (res != DialogResult.OK) return;
            filename = saveFileDialog1.FileName;

            xml.Save(filename);
        }
    }
    public class Device
    {
        public int id;
        public string name;
    }
    public class Signal
    {
        public int id;
        public string name;
        //public List<Device> devices;
    }
}
