using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÀrduinoConsole {
    class Program {
        static void Main(string[] args) {
            SerialPort port = new SerialPort();
            port.BaudRate = 9600;
            port.PortName = "COM6";
            port.Open();

            while(true) {
                String data = port.ReadLine();
                Console.WriteLine(data);
            }
        }
    }
}
