using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //IProductsService _productsService;
        private IProductsService _productsService;
        private readonly IProductsDal _productsDal;

        public ProductsController(IProductsService productService, IProductsDal productsDal)
        {
            _productsService = productService;
            _productsDal = productsDal;
            
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency chain

            //Thread.Sleep(1000);

            //return Ok(dbContext.Products.ToList());

            var result = _productsService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productsService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Products products)
        {
            var result = _productsService.Add(products);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var productToDelete = _productsDal.Get(p => p.Id == id);
            if (productToDelete == null)
            {
                return NotFound(new { message = Messages.ProductNotFound });
            }

            _productsDal.Delete(productToDelete);
            return Ok(new { message = Messages.ProductDeleted });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,Products updatedProduct)
        {
            var productToUpdate = _productsDal.Get(p => p.Id == id);
            if (productToUpdate == null)
            {
                return NotFound(new { message = Messages.ProductNotFound });
            }
            productToUpdate.Name = updatedProduct.Name;
            productToUpdate.NumberOfProduct = updatedProduct.NumberOfProduct;
            productToUpdate.Price = updatedProduct.Price;
            productToUpdate.Description = updatedProduct.Description;
            productToUpdate.CreatedDate = updatedProduct.CreatedDate;
            productToUpdate.CreatedUserId = updatedProduct.CreatedUserId;
            productToUpdate.IsActive = updatedProduct.IsActive;
            productToUpdate.IsDeleted = updatedProduct.IsDeleted;

            _productsDal.Update(productToUpdate);

            return Ok(new { message = Messages.ProductUpdated });
        }
    }
}
