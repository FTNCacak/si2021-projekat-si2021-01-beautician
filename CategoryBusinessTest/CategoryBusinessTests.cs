using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Models;
using Shared.Interfaces;
using System.Collections.Generic;
using BeuticianBusiness;
using Moq;
namespace CategoryBusinessTest
{
    [TestClass]
    public class CategoryBusinessTests
    {
        private Mock<ICategoryRepository> mockCategoryRepository = new Mock<ICategoryRepository>();

        private Category category = new Category
        {

            CategoryId = 1,
            Name = "Nova kategorija",
            Description = "Opis nove kategorije"

        };

        private CategoryBusiness CategoryBusiness;
        private List<Category> categories = new List<Category>();

        public CategoryBusinessTests()
        {

            categories.Add(category);


            categories.Add(new Category
            {

                CategoryId = 2,
                Name = "Nova kategorija 2",
                Description = "Opis nove kategorije 2"


            });


            categories.Add(new Category
            {
                CategoryId = 3,
                Name = "Nova kategorija 3",
                Description = "Opis nove kategorije 3"
            });
        }

        [TestMethod]
        public void IsCategoryInserted()
        {
            mockCategoryRepository.Setup(x => x.InsertCategory(category));

            this.CategoryBusiness = new CategoryBusiness(mockCategoryRepository.Object);

            bool result = false;
            try
            {


                CategoryBusiness.InsertCategory(category);
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
            mockCategoryRepository.Setup(x => x.UpdateCategory(category));

            this.CategoryBusiness = new CategoryBusiness(mockCategoryRepository.Object);

            bool result = false;
            try
            {


                CategoryBusiness.UpdateCategory(category);
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
            mockCategoryRepository.Setup(x => x.DeleteCategory(category.CategoryId));

            this.CategoryBusiness = new CategoryBusiness(mockCategoryRepository.Object);

            bool result = false;
            try
            {


                CategoryBusiness.DeleteCategory(category.CategoryId);
                result = true;
            }
            catch
            {
                result = false;
            }


            Assert.IsTrue(result);
        }


        public void AreCategoriesReturned()
        {
            mockCategoryRepository.Setup(x => x.GetCategories()).Returns(categories);

            this.CategoryBusiness = new CategoryBusiness(mockCategoryRepository.Object);

            List<Category> list = CategoryBusiness.GetCategories();


            Assert.IsTrue(list.Count > 0);
        }
    }
}
