using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTask

{
    internal class MobilePhone
    {

        private string Processor { get; set; }
        private string Network { get; set; }
        private float Width { get; set; }
        private float Height { get; set; }
        private string OSVersion { get; set; }
        private string Chipset { get; set; }
        private string CPU { get; set; }
        private string Brand { get; set; }

        public MobilePhone(string processor, string network, float width, float height,
            string OSversion, string chipset, string cpu, string brand)
        { 
            this.Processor = processor; 
            this.Network=network;
            this.Width=width;
            this.Height=height;
            this.OSVersion=OSversion;
            this.Chipset=chipset;
            this.CPU=cpu;
            this.Brand=brand;
        }



            private void StartDevice()
        {
            Console.WriteLine("Welcome to Android...");
            Console.WriteLine("Your phone contains " + this.Processor + " processor ," + this.Network+" network ,width "+this.Width+ ", height " + this.Height 
                + " ,OSversion is " + this.OSVersion + ",chipset is " + this.Chipset+ ", CPU is " + this.CPU+ " and it's brand is " + this.Brand);

        }

        public void TurnOn()
        {
            Console.WriteLine("Power On...");
            StartDevice();
            
        }
        public void TurnOFF()
        {

            Console.WriteLine("Power Off....");
        }
    }
}
