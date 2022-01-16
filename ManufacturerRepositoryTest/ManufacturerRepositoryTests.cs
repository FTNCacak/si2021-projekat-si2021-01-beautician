using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Models;
using BeuticianData;
using System.Linq;

namespace ManufacturerRepositoryTest
{
    [TestClass]
    public class ManufacturerRepositoryTests
    {
        public Manufacturer manufacturer;

        public ManufacturerRepository manufacturerRepository;

        [TestInitialize]
        public void init()
        {

            manufacturer = new Manufacturer
            {
                Name = "Novi proizvodjac"
            };
            manufacturerRepository = new ManufacturerRepository();
            manufacturerRepository.InsertManufacturer(manufacturer);
        }
       
        [TestMethod]
        public void GetManufacturersTest()
        {
            Assert.IsNotNull(manufacturerRepository.GetManufacturers());
        }


        [TestMethod]
        public void UpdateManufacturerTest()
        {
           

            Manufacturer newManufacturer = manufacturerRepository.GetManufacturers().Where(x => x.Name == manufacturer.Name).ToList()[0];

            bool result;
            try
            {
                result = true;
                manufacturerRepository.UpdateManufacturer(newManufacturer);
            }
            catch {
                result = false;
            }

            Assert.IsTrue(result);

        }



        [TestMethod]
        public void DeleteManufacturerTest()
        {

            Manufacturer newManufacturer = manufacturerRepository.GetManufacturers().Where(x => x.Name == manufacturer.Name).ToList()[0];

            bool result;
            try
            {
                result = true;
                manufacturerRepository.DeleteManufacturer(newManufacturer.ManufacturerId);
            }
            catch
            {
                result = false;
            }

            Assert.IsTrue(result);

        }


    }
}
