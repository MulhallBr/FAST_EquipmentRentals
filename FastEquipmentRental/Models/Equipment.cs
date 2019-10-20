using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastEquipmentRental.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool Availability { get; set; }
    }
}
