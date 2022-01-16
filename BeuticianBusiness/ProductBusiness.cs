using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianBusiness
{
   public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository productRepository;

        public ProductBusiness(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void InsertProduct(Product product)
        {
            productRepository.InsertProduct(product);
        }

        public void DeleteProduct(int ProductId)
        {
            productRepository.DeleteProduct(ProductId);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.UpdateProduct(product);
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }
    }
}
