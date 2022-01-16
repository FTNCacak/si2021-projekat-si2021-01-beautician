using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianBusiness
{
    public class CategoryBusiness :  ICategoryBusiness
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryBusiness(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void InsertCategory(Category category)
        {
            categoryRepository.InsertCategory(category);
        }

        public void DeleteCategory(int CategoryId)
        {
            categoryRepository.DeleteCategory(CategoryId);
        }

        public void UpdateCategory(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }

        public List<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }

    }
}
