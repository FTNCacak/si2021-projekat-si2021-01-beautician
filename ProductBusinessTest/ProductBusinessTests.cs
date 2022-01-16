using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Interfaces;
using Shared.Models;
using Moq;
using BeuticianBusiness;
using System.Collections.Generic;

namespace ProductBusinessTest
{
    [TestClass]
    public class ProductBusinessTests
    {

        private Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();

        private Product product = new Product {
            
            ProductId = 1,
            Name = "Novi proizvod",
            Price = 300,
            Amount = 20,
            Description = "Opis novog proizvoda",
            ManufacturerId = 1,
            CategoryId = 1
        };

        private ProductBusiness productBusiness;
        private List<Product> products = new List<Product>();

        public ProductBusinessTests()
        {

            products.Add(product);


            products.Add(new Product {

                ProductId = 2,
                Name = "Novi proizvod 2",
                Price = 150,
                Amount = 100,
                Description = "Opis novog proizvoda 2",
                ManufacturerId = 1,
                CategoryId = 1


            });


            products.Add(new Product
            {

                ProductId = 3,
                Name = "Novi proizvod 3",
                Price = 400,
                Amount = 20,
                Description = "Opis novog proizvoda 3",
                ManufacturerId = 2,
                CategoryId = 3
            });
        }

        [TestMethod]
        public void IsProductInserted()
        {
            mockProductRepository.Setup(x => x.InsertProduct(product));

            this.productBusiness = new ProductBusiness(mockProductRepository.Object);

            bool result = false;
            try {


                productBusiness.InsertProduct(product);
                result = true;
            }
            catch {
                result = false;
            }


            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsProductUpdated()
        {
            mockProductRepository.Setup(x => x.UpdateProduct(product));

            this.productBusiness = new ProductBusiness(mockProductRepository.Object);

            bool result = false;
            try
            {


                productBusiness.UpdateProduct(product);
                result = true;
            }
            catch
            {
                result = false;
            }


            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsProductDeleted()
        {
            mockProductRepository.Setup(x => x.DeleteProduct(product.ProductId));

            this.productBusiness = new ProductBusiness(mockProductRepository.Object);

            bool result = false;
            try
            {


                productBusiness.DeleteProduct(product.ProductId);
                result = true;
            }
            catch
            {
                result = false;
            }


            Assert.IsTrue(result);
        }


        public void AreProductsReturned()
        {
            mockProductRepository.Setup(x => x.GetProducts()).Returns(products);

            this.productBusiness = new ProductBusiness(mockProductRepository.Object);

            List<Product> list = productBusiness.GetProducts();


            Assert.IsTrue(list.Count > 0);
        }

    }
}
