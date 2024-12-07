using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarModelManageMent.Data;
using Microsoft.AspNetCore.Mvc;

namespace CarModelManageMent
{
    [ApiController]
    [Route("api/Car")]
    public class CarController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CarController(ApplicationDBContext context)
        {
            _context = context;            
        }
        [HttpGet, Route("GetCars")]
        public IActionResult GetCar()
        {
            if(!_context.CarModels.Any())
            {
                return NoContent();
            }
            return Ok(_context.CarModels.ToList());
        }
    }
}