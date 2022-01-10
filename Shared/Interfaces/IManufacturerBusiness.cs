using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
namespace Shared.Interfaces
{
    public interface IManufacturerBusiness
    {
        void InsertManufacturer(Manufacturer manufacturer);
        void DeleteManufacturer(int ManufacturerId);
        void UpdateManufacturer(Manufacturer manufacturer);
        List<Manufacturer> GetManufacturers();
    }
}
