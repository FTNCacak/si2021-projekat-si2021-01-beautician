using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Models;
using BeuticianData;
using System.Linq;
namespace ProductRepositoryTest
{
    [TestClass]
    public class ProductRepositoryTests
    {
        public Category category;
        public Manufacturer manufacturer;
        public Product product;

        public CategoryRepository categoryRepository;
        public ManufacturerRepository manufacturerRepository;
        public ProductRepository productRepository;

        [TestInitialize]
        public void init()
        {

            categoryRepository = new CategoryRepository();
            manufacturerRepository = new ManufacturerRepository();
            productRepository = new ProductRepository();

            category = new Category
            {
                Name = "Nova kategorija",
                Description = "Opis nove kategorije"
            };

            manufacturer = new Manufacturer
            {
                Name = "Novi proizvodjac"
            };

            manufacturerRepository.InsertManufacturer(manufacturer);
            categoryRepository.InsertCategory(category);

            int categoryId = categoryRepository.GetCategories().Where(x => x.Name == category.Name).ToList()[0].CategoryId;

            int manufacturerId = manufacturerRepository.GetManufacturers().Where(x => x.Name == manufacturer.Name).ToList()[0].ManufacturerId;



            product = new Product
            {

                Name = "Novi proizvod",
                Price = 500,
                Amount = 100,
                Description = "Opis novog proizvoda",
                CategoryId = categoryId,
                ManufacturerId = manufacturerId,
                Image = "image.jpg"

            };

            productRepository.InsertProduct(product);
        }

        [TestMethod]
        public void GetProductsTest()
        {

            Assert.IsNotNull(productRepository.GetProducts());
        }


        [TestMethod]
        public void UpdateProductTest()
        {


            Product newProduct = productRepository.GetProducts().Where(x => x.Name == product.Name).ToList()[0];

            bool result;
            try
            {
                result = true;
                productRepository.UpdateProduct(newProduct);
            }
            catch
            {
                result = false;
            }

            Assert.IsTrue(result);

        }



        [TestMethod]
        public void DeleteProductTest()
        {

            Product newProduct = productRepository.GetProducts().Where(x => x.Name == product.Name).ToList()[0];

            bool result;
            try
            {
                result = true;
                productRepository.DeleteProduct(newProduct.ProductId);
            }
            catch
            {
                result = false;
            }

            Assert.IsTrue(result);
        }


        [TestCleanup]
        public void Clean()
        {
            int categoryId = categoryRepository.GetCategories().Where(x => x.Name == category.Name).ToList()[0].CategoryId;

            int manufacturerId = manufacturerRepository.GetManufacturers().Where(x => x.Name == manufacturer.Name).ToList()[0].ManufacturerId;


            categoryRepository.DeleteCategory(categoryId);
            manufacturerRepository.DeleteManufacturer(manufacturerId);

        }

    }
}
