using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
namespace Shared.Interfaces
{
    public interface IProductBusiness
    {
        void InsertProduct(Product product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(Product product);
        List<Product> GetProducts();
    }
}
