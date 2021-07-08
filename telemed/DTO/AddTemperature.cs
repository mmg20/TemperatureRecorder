using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telemed.DTO
{
    public class AddTemperature
    {
        public double value { get; set; }
        public string location { get; set; }
        public string sensorName { get; set; }
    }
}
