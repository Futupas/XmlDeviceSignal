using System;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace XmlDeviceSignal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Device> devices = new List<Device>();
        private List<Signal> signals = new List<Signal>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_LoadDevices_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select file with devices";
            var res = openFileDialog1.ShowDialog();
            if (res != DialogResult.OK) return;
            var filename = openFileDialog1.FileName;
            
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filename);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xdev in xRoot)
            {
                Device dev = new Device();
                string sid = xdev.HasAttribute("id") ? xdev.GetAttribute("id") : "0";
                int id = int.Parse(sid);
                string name = xdev.HasAttribute("name") ? xdev.GetAttribute("name") : "";

                dev.id = id;
                dev.name = name;

                devices.Add(dev);
            }
        }

        private void btn_LoadSignals_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select file with signals";
            var res = openFileDialog1.ShowDialog();
            if (res != DialogResult.OK) return;
            var filename = openFileDialog1.FileName;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filename);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xsig in xRoot)
            {
                Signal sig = new Signal();
                string sid = xsig.HasAttribute("id") ? xsig.GetAttribute("id") : "0";
                int id = int.Parse(sid);
                string name = xsig.HasAttribute("name") ? xsig.GetAttribute("name") : "";

                sig.id = id;
                sig.name = name;

                signals.Add(sig);
            }
        }

        PanWebsite Website;
        private void button1_Click(object sender, EventArgs e)
        {
            Website = new PanWebsite(textBox1.Text, OnRequest);
            if (devices.Count > 0 && signals.Count > 0)
            {
                Website.Start();
                System.Diagnostics.Process.Start(textBox1.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Website.Stop();
        }
        public PanResponse OnRequest(PanRequest request)
        {
            if (request.Address.Length < 1) return PanResponse.ReturnFile("./Website/index.html");
            else if (request.Address[0].ToLower() == "styles.css") return PanResponse.ReturnFile("./Website/styles.css");
            else if (request.Address[0].ToLower() == "app.js") return PanResponse.ReturnFile("./Website/app.js");
            else if (request.Address[0].ToLower() == "getsignals")
            {
                return PanResponse.ReturnJson(signals);
            }
            else if (request.Address[0].ToLower() == "getdevices")
            {
                return PanResponse.ReturnJson(devices);
            }

            return PanResponse.ReturnEmtry();
        }
    }

}
