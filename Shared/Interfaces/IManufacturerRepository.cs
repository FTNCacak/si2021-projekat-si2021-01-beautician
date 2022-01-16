using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
   public interface IManufacturerRepository
    {
        void InsertManufacturer(Manufacturer manufacturer);
        void DeleteManufacturer(int manufacturerId);
        void UpdateManufacturer(Manufacturer manufacturer);
        List<Manufacturer> GetManufacturers();
    }
}
