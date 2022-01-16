using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Models;
using Shared.Interfaces;
using System.Collections.Generic;
using Moq;
using BeuticianBusiness;
namespace ManufacturerBusinessTest
{
    [TestClass]
    public class ManufacturerBusinessTests
    {
        private Mock<IManufacturerRepository> mockManufactureRepository = new Mock<IManufacturerRepository>();

        private Manufacturer manufacturer = new Manufacturer
        {

            ManufacturerId = 1,
            Name = "Novi proizvodjac",

        };

        private ManufacturerBusiness ManufacturerBusiness;
        private List<Manufacturer> manufacturers = new List<Manufacturer>();

        public ManufacturerBusinessTests()
        {

            manufacturers.Add(manufacturer);


            manufacturers.Add(new Manufacturer
            {

                ManufacturerId = 2,
                Name = "Novi proizvodjac 2",


            });


            manufacturers.Add(new Manufacturer
            {
                ManufacturerId = 3,
                Name = "Novi proizvodjac 3",
            });
        }

        [TestMethod]
        public void IsManufacturerInserted()
        {
            mockManufactureRepository.Setup(x => x.InsertManufacturer(manufacturer));

            this.ManufacturerBusiness = new ManufacturerBusiness(mockManufactureRepository.Object);

            bool result = false;
            try
            {


                ManufacturerBusiness.InsertManufacturer(manufacturer);
                result = true;
            }
            catch
            {
                result = false;
            }


            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsManufacturerUpdated()
        {
            mockManufactureRepository.Setup(x => x.UpdateManufacturer(manufacturer));

            this.ManufacturerBusiness = new ManufacturerBusiness(mockManufactureRepository.Object);

            bool result = false;
            try
            {


                ManufacturerBusiness.UpdateManufacturer(manufacturer);
                result = true;
            }
            catch
            {
                result = false;
            }


            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsManufacturerDeleted()
        {
            mockManufactureRepository.Setup(x => x.DeleteManufacturer(manufacturer.ManufacturerId));

            this.ManufacturerBusiness = new ManufacturerBusiness(mockManufactureRepository.Object);

            bool result = false;
            try
            {


                ManufacturerBusiness.DeleteManufacturer(manufacturer.ManufacturerId);
                result = true;
            }
            catch
            {
                result = false;
            }


            Assert.IsTrue(result);
        }


        public void AreManufacturersReturned()
        {
            mockManufactureRepository.Setup(x => x.GetManufacturers()).Returns(manufacturers);

            this.ManufacturerBusiness = new ManufacturerBusiness(mockManufactureRepository.Object);

            List<Manufacturer> list = ManufacturerBusiness.GetManufacturers();


            Assert.IsTrue(list.Count > 0);
        }
    }
}
