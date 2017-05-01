using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FXMM.Data;
using FXMM.Entity;
using FXMM.Infrastructure;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FXMM.Controllers.Admin
{
    [Route("api/[controller]")]
    public class CounterPartyController : Controller
    {
        private readonly IRepository<CounterParty> _repository;

        public CounterPartyController(IRepository<CounterParty> repository)
        {
            this._repository = repository;
        }

        // GET: api/values
        [HttpGet]
        [NoCache]
        public IEnumerable<CounterParty> Get()
        {
            return _repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public CounterParty Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CounterParty value)
        {
            _repository.Insert(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CounterParty value)
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
