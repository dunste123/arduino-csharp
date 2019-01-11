using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoToCSHARP_21_mar_2018 {
    public partial class Form1 : Form {

        public SerialPort port;

        public Form1() {
            InitializeComponent();

            port = new SerialPort();
            port.BaudRate = 9600;
            port.PortName = "COM6";
        }

        private void btnOn_Click(object sender, EventArgs e) {
            Send("O");
        }

        private void btnOff_Click(object sender, EventArgs e) {
            Send("F");
        }

        private void Send(String data) {
            port.Open();
            port.WriteLine(data);
            port.Close();
        }
    }
}
