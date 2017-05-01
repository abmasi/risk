using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FXMM.Entity;
using FXMM.Data;
using FXMM.Infrastructure;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FXMM.Controllers.Admin
{
    [Route("api/[controller]")]
    public class CurrencyProfileController : Controller
    {
        private readonly IRepository<CurrencyProfile> _repository;

        public CurrencyProfileController(IRepository<CurrencyProfile> repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet]
        [NoCache]
        public IEnumerable<CurrencyProfile> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet]
        [NoCache]
        public async Task<IEnumerable<CurrencyProfile>> GetAsync()
        {
            return await _repository.GetAllAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public CurrencyProfile Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CurrencyProfile value)
        {
            _repository.Insert(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CurrencyProfile value)
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
