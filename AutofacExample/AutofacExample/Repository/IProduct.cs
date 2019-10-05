using AutofacExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacExample.Repository
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductByID(int id);
        Product AddProduct(Product item);
        bool UpdateProduct(Product item);
        bool DeleteProduct(int id);
    }
}
