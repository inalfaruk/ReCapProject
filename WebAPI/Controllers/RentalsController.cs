﻿using Business.Abstract;
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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalSevice)
        {

            _rentalService = rentalSevice;
        }

         [HttpGet ("getall")]
        public IActionResult GetAll()
        {

            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);


        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _rentalService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result);
        }



        [HttpPost("add")]
        public IActionResult Add(Rental rental, int carId)
        {
            var result = _rentalService.Add(rental, carId);

            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getrentlist")]
        public IActionResult GetRentList()
        {
            var result = _rentalService.GetRentList();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
