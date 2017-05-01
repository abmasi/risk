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
    public class RoleController : Controller
    {
        private readonly IRepository<Role> _repository;

        public RoleController(IRepository<Role> repository)
        {
            _repository = repository;
        }
        
        // GET: api/values
        [HttpGet]
        [NoCache]
        public async Task<IEnumerable<Role>> Get()
        {
            return await _repository.GetAllAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Role value)
        {
            _repository.Insert(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Role value)
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
