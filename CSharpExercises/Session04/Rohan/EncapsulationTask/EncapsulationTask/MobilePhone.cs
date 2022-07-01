using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
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

        public MobilePhone(string process, string network, float width, float height, string version, string chipset, string cpu, string brand)
        {
            Processor = process;
            Network = network;
            Width = width;
            Height = height;
            OSVersion = version;
            Chipset = chipset;
            CPU = cpu;
            Brand = brand;
        }

        private void StartDevice()
        {
            Console.WriteLine("Welcome");
        }

        public void TurnOn()
        {
            StartDevice();
            Console.WriteLine("\nSpecification \n");
            Console.WriteLine("Processor: {0} \nNetwork: {1} \nWidth: {2} \nHeight: {3} \nVersion: {4} \nChipset: {5} \nCPU: {6} \nBrand: {7} " +
                "",Processor,Network,Width,Height,OSVersion,Chipset,CPU,Brand);

        }
        public void TurnOff()
        {
            Console.WriteLine("\nSwitching off");
        }
    }
}
