using Practical.Data;
using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Services
{
    public class ProductsService:IProductService
    {
        private readonly PracticeContext _practiceContext;
        public ProductsService(PracticeContext practiceContext) 
        {
            this._practiceContext = practiceContext;
        }

        public async Task AddProduct(Products products)
        {
          await  _practiceContext.product.AddAsync(products);
            await _practiceContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Products>> GetAllProduct()
        {
          return   _practiceContext.product.ToList();
        }

        public async Task<Products> GetProductsById(int id)
        {
           var ret=  _practiceContext.product.Find(id);
            return ret;
        }
    }
}
