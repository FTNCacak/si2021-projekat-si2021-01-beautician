using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Models;
using BeuticianData;
using System.Linq;

namespace CategoryRepositoryTest
{
    [TestClass]
    public class CategoryRepositoryTests
    {

        public Category category;

        public CategoryRepository categoryRepository;

        [TestInitialize]
        public void init()
        {

            category = new Category
            {
                Name = "Nova kategorija",
                Description = "Opis nove kategorije"
            };
            categoryRepository = new CategoryRepository();
            categoryRepository.InsertCategory(category);
        }

        [TestMethod]
        public void GetCategoriesTest()
        {
            Assert.IsNotNull(categoryRepository.GetCategories());
        }


        [TestMethod]
        public void UpdateCategoryTest()
        {


            Category newCategory = categoryRepository.GetCategories().Where(x => x.Name == category.Name).ToList()[0];

            bool result;
            try
            {
                result = true;
                categoryRepository.UpdateCategory(newCategory);
            }
            catch
            {
                result = false;
            }

            Assert.IsTrue(result);

        }



        [TestMethod]
        public void DeleteCategoryTest()
        {

            Category newCategory = categoryRepository.GetCategories().Where(x => x.Name == category.Name).ToList()[0];

            bool result;
            try
            {
                result = true;
                categoryRepository.DeleteCategory(newCategory.CategoryId);
            }
            catch
            {
                result = false;
            }

            Assert.IsTrue(result);
        }


    }
}
