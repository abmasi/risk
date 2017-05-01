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
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AccruedBasisController : Controller
    {
        private IRepository<AccruedBasis> _repository;

        public AccruedBasisController(IRepository<AccruedBasis> repository)
        {
            this._repository = repository;
        }

        // GET: api/values
        [HttpGet]
        [NoCache]
        public IEnumerable<AccruedBasis> Get()
        {
            return _repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public AccruedBasis Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]AccruedBasis value)
        {
            _repository.Insert(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]AccruedBasis value)
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
