using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    internal class Smartphone : ElectronicDevice
    {
        private int _screenSize;
        private bool _has5G {  get; set; }
        public int ScreenSize
        {
            get { return _screenSize; }
            set
            {
                if (value <= 0)
                {
                    value = 0;

                    Console.WriteLine("Seems like the phone doesn't have a screen.");
                }
                _screenSize = value;
            }
        }
        public Smartphone(string brand, string model, decimal batteryCapacity, decimal usageTime, decimal chargeTime, int screenSize, bool has5G) : base(brand, model, batteryCapacity, usageTime, chargeTime)
        {
            ScreenSize = screenSize;
            _has5G = has5G;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Screen Size : {_screenSize} inch , Has 5G : {_has5G}.");
        }
        public override void DefineCategory()
        {
            Console.WriteLine("Smartphone");
        }
    }
}
