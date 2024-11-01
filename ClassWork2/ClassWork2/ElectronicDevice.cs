using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    internal abstract class ElectronicDevice
    {
        private string _brand { get; set; }
        private string _model { get; set; }
        private decimal _batteryCapacity;
        private decimal _usagetime;
        private decimal _chargeTime;

        public decimal BatteryCapacity
        {
            get { return _batteryCapacity; }
            set
            {
                if (_batteryCapacity < 0)
                {
                    _batteryCapacity = 0;
                }
            _batteryCapacity = value;
            }
        }
        public decimal UsageTime
        {
            get { return _usagetime; }
            set
            {
                if (_usagetime < 0)
                {
                    _usagetime = 0;
                }
            _usagetime = value;
            }
        }
        public decimal ChargeTime
        {
            get { return _usagetime; }
            set
            {
                if (_usagetime < 0)
                {
                    _usagetime = 0;
                }
                _usagetime = value;
            }
        }
        public ElectronicDevice(string brand, string model, decimal batteryCapacity, decimal usageTime, decimal chargeTime)
        {
            _brand = brand;
            _model = model;
            BatteryCapacity = batteryCapacity;
            UsageTime = usageTime;
            ChargeTime = chargeTime;
        }
        public decimal CalculatePowerEfficiency()
        {
            return _usagetime / _batteryCapacity;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand : {_brand} , Model : {_model} , Battery Capacity : {_batteryCapacity} mAh , Usage Time : {_usagetime} hours , Charge Time : {_chargeTime} hours.");
        }
        public void ToString()
        {
            Console.WriteLine($"Brand : {_brand} , Model : {_model}.");
        }
        public abstract void DefineCategory();
    }
}
