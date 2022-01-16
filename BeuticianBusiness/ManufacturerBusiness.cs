using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;
namespace BeuticianBusiness
{
    public class ManufacturerBusiness : IManufacturerBusiness
    {
        private readonly IManufacturerRepository manufacturerRepository;

        public ManufacturerBusiness(IManufacturerRepository manufacturerRepository)
        {
            this.manufacturerRepository = manufacturerRepository;
        }

        public void InsertManufacturer(Manufacturer manufacturer)
        {
            manufacturerRepository.InsertManufacturer(manufacturer);
        }

        public void DeleteManufacturer(int ManufacturerId)
        {
            manufacturerRepository.DeleteManufacturer(ManufacturerId);
        }

        public void UpdateManufacturer(Manufacturer manufacturer)
        {
            manufacturerRepository.UpdateManufacturer(manufacturer);
        }

        public List<Manufacturer> GetManufacturers()
        {
            return manufacturerRepository.GetManufacturers();
        }
    }
}
