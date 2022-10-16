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
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _orderService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getorderdetails")]
        public IActionResult GetOrderDetails()
        {
            var result = _orderService.GetOrderDetails();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getorderdetailbyuserid")]
        public IActionResult GetOrderDetailByUserId(int userId)
        {
            var result = _orderService.GetOrderDetailByUserId(userId);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("insert")]
        public IActionResult Insert(Order order)
        {
            var result = _orderService.Insert(order);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Order order)
        {
            var result = _orderService.Update(order);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Order order)
        {
            var result = _orderService.Delete(order);
            return result.Success ? Ok(result) : BadRequest(result);
        }

    }
}
