using Microsoft.AspNetCore.Mvc;
using Practical.Models;
using Practical.Services;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practical.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;  
            public ProductsController( IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        [SwaggerOperation(Summary = "Get All Product", Description = "All Products ")]
        [SwaggerResponse(200, "List of Product")]
        public async Task<IEnumerable<Products>> AllProducts()
        {
           return  await  _productService.GetAllProduct();
        }

        // GET api/<ProductsController>/
        [HttpGet("{id}")]
        [SwaggerOperation(Summary ="Get products by Id", Description ="A Products")]
        [SwaggerResponse(200, "Products by Id")]
        public async Task<Products> GetproductById(int id)
        {
          var rett= await  _productService.GetProductsById(id);
            return rett;
        }

        // POST api/<ProductsController>
        [HttpPost]
        [SwaggerOperation(Summary="Posting product", Description="Product Added")]
        [SwaggerResponse(200, "Product Added")]
        public async Task Addproduct( Products products )
        {

            if (ModelState.IsValid)
            {
                await _productService.AddProduct(products);
            }
            
                      
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
