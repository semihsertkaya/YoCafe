using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _productService.GetById(Id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getproductdetails")]
        public IActionResult GetProductDetails()
        {
            var result = _productService.GetProductDetails();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getproductdetailbycategoryid")]
        public IActionResult GetProductDetailByCategoryId(int categoryId)
        {
            var result = _productService.GetProductDetailByCategoryId(categoryId);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getproductdetailbyid")]
        public IActionResult GetProductDetailById(int Id)
        {
            var result = _productService.GetProductDetailById(Id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("insert")]
        public IActionResult Insert(Product product)
        {
            var result = _productService.Insert(product);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
