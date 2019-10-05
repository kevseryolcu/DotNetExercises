using AutofacExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacExample.Repository
{
    public class ProductRepo : IProduct
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepo()
        {
            AddProduct(new Product { Name = "Computer", Category = "Electronics", Price = 4000 });
            AddProduct(new Product { Name = "XBOX ONE", Category = "Electronics", Price = 400 });
            AddProduct(new Product { Name = "IPhone7", Category = "Phone", Price = 1000 });
            AddProduct(new Product { Name = "Computer", Category = "Electronics", Price = 4000 });
            AddProduct(new Product { Name = "XBOX ONE", Category = "Electronics", Price = 400 });
            AddProduct(new Product { Name = "IPhone7", Category = "Phone", Price = 1000 });
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return products;
        }
        public Product GetProductByID(int id)
        {
            return products.Find(p => p.Id == id);
        }
        public Product AddProduct(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            
            item.Id = _nextId++;
            products.Add(item);
            return item;
        }
        public bool UpdateProduct(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
        public bool DeleteProduct(int id)
        {
            products.RemoveAll(p => p.Id == id);
            return true;
        }
    }
}