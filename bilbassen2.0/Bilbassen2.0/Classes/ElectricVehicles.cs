using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ElectricCar
    {

        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;
        public int PowerHP { get; set; }
        public int BatteryCapacityKWH { get; set; }
        public int Price { get; set; }
        public int KilometerDriven { get; set; }
    }
}
