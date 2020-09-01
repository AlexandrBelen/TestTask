using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using TestTask.Context;
using TestTask.Models;
using TestTask.Services;

namespace TestTask.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CarController : ControllerBase
    {
        public CarController(DataContext data) => context = data;
        DataContext context;
        CarService service;

        [HttpPost]
        public async Task<ActionResult> GetOwnerCars([FromBody] OwnerViewModel owner)
        {
            int id = -1;
            List<Owner> owners = context.Owners.ToList();
            for (int i = 0; i < owners.Count; i++)
            {
                if (owners[i].Name == owner.Name && owners[i].LastName == owner.LastName && owners[i].MidName == owner.MidName)
                {
                    id = owners[i].Id;
                    break;
                }
            }
            if (id == -1) return BadRequest();
            var data = from c in context.Cars
                       join co in context.CarOwners
                       on c.Id equals co.CarId
                       where co.OwnerId == id
                       select new
                       {
                           c.Number,
                           c.Brand,
                           c.Model,
                           c.Color,
                           c.Year
                       };
            return Ok(data);

        }

        [HttpGet]
        [Route("/{number}")]
        public async Task<ActionResult> GetOwner([FromHeader]CarViewModel car)
        {
            int id = -1;
            List<Car> cars = context.Cars.ToList();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Number == car.Number)
                {
                    id = cars[i].Id;
                    break;
                }
            }
            if (id == -1) return BadRequest();
            var data = from o in context.Owners
                       join co in context.CarOwners
                       on o.Id equals co.OwnerId
                       where co.CarId == id
                       select new
                       {
                           o.Name,
                           o.LastName,
                           o.MidName
                       };
            return Ok(data);
        }

        
    }
}