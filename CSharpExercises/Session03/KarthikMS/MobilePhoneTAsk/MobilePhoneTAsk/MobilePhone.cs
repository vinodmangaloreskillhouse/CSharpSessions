using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneTask
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
        public MobilePhone(string Processor, string Network, float Width, float Height, string OSVersion, string Chipset, string CPU, string Brand)

        {
            this.Processor = Processor;
            this.Network = Network;
            this.Width = Width;
            this.Height = Height;
            this.OSVersion = OSVersion;
            this.Chipset = Chipset;
            this.CPU = CPU;
            this.Brand = Brand;
            Console.WriteLine("About MobilePhone");
            Console.WriteLine("Processor : "+this.Processor+"\nNetwork : "+this.Network+"\nWidth : "+this.Width+"\nHeight : "+this.Height+ "\nOSVersion : "+this.OSVersion+ "\nChipset :" + this.Chipset + "\nCPU : " + this.CPU + "\nBrand : " + this.Brand);
        }
         private void StartDevice()
         {
            Console.WriteLine("Mobile phone started");
         }
         public void TurnOn()
         {
            Console.WriteLine("MobilePhone turned On");
            StartDevice();

         }
         public void TurnOff()
         {
            Console.WriteLine("MobilePhone Turned off");
         }
    }
}

       
    
    
       
    


