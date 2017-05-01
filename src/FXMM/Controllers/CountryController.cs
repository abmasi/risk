using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FXMM.Data;
using FXMM.Entity;
using System;
using FXMM.Infrastructure;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FXMM.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly IRepository<Country> _repository;


        public CountryController(IRepository<Country> repository)
        {
            _repository = repository;
        }


        // GET: api/values
        [NoCache]
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            Post();
            return _repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Country Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Country value)
        {
            _repository.Insert(value);
        }

        private void Post()
        {
            List<City> city = new List<City>();
            city.Add(new City() { Id = 1, CITY = "Paramus", CITY_DESCRIPTION = "Paramus" });

            _repository.Insert(new Country()
            {
                Id = 1,
                City = city,
                COUNTRY = "USA",
                COUNTRY_DESCRIPTION = "United States",
                ISO_CODE = "US"
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Country value)
        {
            _repository.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
