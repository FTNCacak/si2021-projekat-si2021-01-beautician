using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
   public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }

        public string Image { get; set; }


        public Product() { }

        public Product(int productId, string name, decimal price, int amount, string description, int categoryId, int manufacturerId)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Amount = amount;
            Description = description;
            CategoryId = categoryId;
            ManufacturerId = manufacturerId;
        
        }

        public Product(int productId, string name, decimal price, int amount, string description, int categoryId, int manufacturerId, string image)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Amount = amount;
            Description = description;
            CategoryId = categoryId;
            ManufacturerId = manufacturerId;
            Image = image;
        }
    }
}
