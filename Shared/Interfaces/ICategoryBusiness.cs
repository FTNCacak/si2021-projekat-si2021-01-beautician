using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
namespace Shared.Interfaces
{
   public interface ICategoryBusiness
    {
        void InsertCategory(Category category);
        void DeleteCategory(int CategoryId);
        void UpdateCategory(Category category);
        List<Category> GetCategories();
    }
}
