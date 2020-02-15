using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRabbit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRabbit.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        // GET: api/Rabbit
        [HttpGet]
        public IEnumerable<Rabbit> Get()
        {
            Rabbit rabb1 = new Rabbit()
            {
                Name = "Gigi",
                Age = 15,
                EyeColor = Rabbit.EyeColors.Blue,
                FurColor = Rabbit.FurColors.Brown,
                Genders = Rabbit.Gender.Male
            };
            Rabbit rabb2 = new Rabbit()
            {
                Name = "Feona",
                Age = 12,
                EyeColor = Rabbit.EyeColors.Black,
                FurColor = Rabbit.FurColors.White,
                Genders = Rabbit.Gender.Male
            };
            Rabbit rabb3 = new Rabbit()
            {
                Name = "Vasile",
                Age = 24,
                EyeColor = Rabbit.EyeColors.Red,
                FurColor = Rabbit.FurColors.Grey,
                Genders = Rabbit.Gender.Male
            };
            List<Rabbit> rabbits = new List<Rabbit>();
            rabbits.Add(rabb1);
            rabbits.Add(rabb2);
            rabbits.Add(rabb3);
            return rabbits;
        }

        // GET: api/Rabbit/5
        [HttpGet("{id}", Name = "Get")]
        public Rabbit Get(int id)
        {
            Rabbit rabb1 = new Rabbit()
            {
                Name = "Gigi",
                Age = 15,
                EyeColor = Rabbit.EyeColors.Blue,
                FurColor = Rabbit.FurColors.Brown,
                Genders = Rabbit.Gender.Male
            };
            Rabbit rabb2 = new Rabbit()
            {
                Name = "Feona",
                Age = 12,
                EyeColor = Rabbit.EyeColors.Black,
                FurColor = Rabbit.FurColors.White,
                Genders = Rabbit.Gender.Male
            };
            Rabbit rabb3 = new Rabbit()
            {
                Name = "Vasile",
                Age = 24,
                EyeColor = Rabbit.EyeColors.Red,
                FurColor = Rabbit.FurColors.Grey,
                Genders = Rabbit.Gender.Male
            };
            return rabb1;
        }

        // POST: api/Rabbit
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            if (ModelState.IsValid)
            {
                // save in database
                return Ok();
            }
            return BadRequest();
        }

        // PUT: api/Rabbit/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
