using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Pharmacy
    {
        public Medicine[] medicines = new Medicine[0];

        public void AddArr(Medicine medicine)
        {
            Array.Resize(ref medicines, medicines.Length + 1);

            medicines[medicines.Length - 1] = medicine;
        }
    }
}
