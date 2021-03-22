using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

   
    
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet ("getall")]
        public IActionResult GetAll() 
        {
            Thread.Sleep(1000);
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

            
        }


        public IActionResult GetById (int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result);
        }



        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);

            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet ("getallcardetail")]
         public IActionResult GetAllCarDetail()
        {
            var result = _carService.GetAllCarDetail();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


        [HttpGet ("getcarsbybrand")]
        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarDetailByBrandId(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


        

    }
}
