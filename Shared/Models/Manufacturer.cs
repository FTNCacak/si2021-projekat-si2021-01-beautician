using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string Name { get; set; }

        public Manufacturer() { }

        public Manufacturer(int manufacturerId, string name)
        {
            ManufacturerId = manufacturerId;
            Name = name;
        }
    }
}
