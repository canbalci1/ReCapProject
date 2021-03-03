using Business.Abstract;
using Entities.Concrate;
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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
          var result = _customerService.GetAll();
          if (result.Success)
          {
            return Ok(result);
          }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int customerid)
        {
            var result = _customerService.GetById(customerid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost ("Add")]
        public IActionResult Add(Customer customers)
        {
            var result = _customerService.Add(customers);
            if (result.Success)
            {
              return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost ("delete")]
        public IActionResult Delete(Customer customers)
        {
            var result = _customerService.Delete(customers);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost ("update")]
        public IActionResult Update(Customer customers)
        {
            var result = _customerService.Update(customers);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
