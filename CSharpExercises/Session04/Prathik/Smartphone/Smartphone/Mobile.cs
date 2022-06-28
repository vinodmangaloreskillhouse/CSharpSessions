using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    internal class Mobile
    {
        private string processor { get; set; }

        private string network { get; set; }

        private float width { get; set; }

        private float height { get; set; }

        private string Osversion { get; set; }

        private string chipset { get; set; }

        private string CPU { get; set; }

        private string brand { get; set; }

        public Mobile(string processor, string network, float width, float height, string Osversion, string chipset, string CPU, string brand)
        {
            this.processor = processor;
            this.network = network;
            this.width = width;
            this.height = height;
            this.Osversion = Osversion;
            this.chipset = chipset;
            this.CPU = CPU;
            this.brand = brand;
            Console.WriteLine("Processor:" + this.processor + "\nNetwork:"+ this.network+ "\nWidth:"+this.width+"\nHeight:"+this.height+"\nOS Version:"+this.Osversion+"\nChipset:"+this.chipset+"\nCPU:"+this.CPU+"\nBrand:"+this.brand);
        }
        private void StartDevice()
        {
            Console.WriteLine("Your device is Starting");
        }
        public void TurnOn()
        {
            StartDevice();
        }
        public void TurnOff()
        {
            Console.WriteLine("Your device is turning off");
        }
    }


}
