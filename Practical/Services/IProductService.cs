using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Services
{
  public  interface IProductService
    {
        public Task AddProduct(Products products);
        public Task<IEnumerable<Products>> GetAllProduct();
        public Task<Products> GetProductsById(int id);
    }
}
