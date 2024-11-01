using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    internal class Laptop : ElectronicDevice
    {
        private string _processorModel {  get; set; }

        private int _ramSize;

        public int RamSize
        {
            get { return _ramSize; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _ramSize = value;
            }
        }
        public Laptop(string brand, string model, decimal batteryCapacity, decimal usageTime, decimal chargeTime, string processorModel, int ramSize) : base(brand, model, batteryCapacity, usageTime, chargeTime)
        {
            _processorModel = processorModel;
            RamSize = ramSize;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Processor Model : {_processorModel} , Ram Size : {_ramSize}");
        }
        public override void DefineCategory()
        {
            Console.WriteLine("Laptop");
        }
    }
}
