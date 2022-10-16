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
    public class PaycellController : ControllerBase
    {
        private IPaycellService _paycellService;

        public PaycellController(IPaycellService paycellService)
        {
            _paycellService = paycellService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _paycellService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(string transactionId)
        {
            var result = _paycellService.GetById(transactionId);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("insert")]
        public IActionResult Insert(Paycell paycell)
        {
            var result = _paycellService.Insert(paycell);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Paycell paycell)
        {
            var result = _paycellService.Update(paycell);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Paycell paycell)
        {
            var result = _paycellService.Delete(paycell);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
