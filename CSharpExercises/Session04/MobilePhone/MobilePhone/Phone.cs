using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    internal class Phone
    {
        private string Processor { get; set; }
        private string Network { get; set; }
        private float Width { get; set; }
        private float Height { get; set; }
        private string OSVersion { get; set; }
        private string Chipset { get; set; }
        private string CPU { get; set; }
        private string Brand { get; set; }
        public Phone( string processor,string network,float width,float height,string osversion,string chipset,string cpu,string brand)
        {
            this.Processor = processor;
            this.Network = network;
            this.Width = width;
            this.Height = height;
            this.OSVersion = osversion;
            this.Chipset = chipset;
            this.CPU = cpu;
            this.Brand = brand;
            Console.WriteLine("Processor of the Phone is:"+this.Processor+" and network used is "+this.Network+" and its Width and Height are "+this.Width+" "+this.Height);
            Console.WriteLine("Other Features are: it consist of " + this.OSVersion + "os version and consist of " + this.Chipset + " chip ." + "CPU is " + this.CPU + " and Brand is " + this.Brand);
        }
        private void StartDevice()
        {
            Console.WriteLine("Mobile phone started");
        }
        public void TurnOn()
        {
            StartDevice();

        }
        public void TurnOff()
        {
            Console.WriteLine("Phone Turnoffed");
        }
    }
}
