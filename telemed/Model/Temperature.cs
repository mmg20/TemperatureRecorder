using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace telemed.Model
{
    public class Temperature
    {
        [Key]
        public Guid id { get; set; }
        public double value { get; set; }
        public DateTime timestamp { get; set; }
        public string location { get; set; }
        public string sensorName { get; set; }

        public Temperature(double value, string location, string sensorName)
        {
            this.id = Guid.NewGuid();
            this.value = value;
            this.timestamp = DateTime.Now;
            this.location = location;
            this.sensorName = sensorName;
        }
    }
}
