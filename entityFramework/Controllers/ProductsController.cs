using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entityFramework.Data;
using entityFramework.Models;
using entityFramework.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace entityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /*
        private readonly AppDbContext _appDbContext;

        public ProductsController(AppDbContext appDbContext )
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            _appDbContext.Products.Add(product);
            await _appDbContext.SaveChangesAsync();

            return Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = _appDbContext.Products.ToList();
            return Ok(products);
        }
        */ 

        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await _productRepository.AddProduct(product);
            await _productRepository.Save();
            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allProducts = _productRepository.GetAll();
            return Ok(allProducts);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (await _productRepository.DeleteProduct(id) == 0)
                return BadRequest("Object does not exists");
            await _productRepository.Save();
            return Ok(id);
        }

    }


}
