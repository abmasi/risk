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
    public class HolidayController : Controller
    {
        private readonly IRepository<Holiday> _reposistory;

        public HolidayController(IRepository<Holiday> reposistory)
        {
            _reposistory = reposistory;
        }

        // GET: api/values
        [HttpGet]
        [NoCache]
        public async Task<IEnumerable<Holiday>> Get()
        {
            return await _reposistory.GetAllAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Holiday Get(int id)
        {
            return _reposistory.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Holiday value)
        {
            _reposistory.Insert(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Holiday value)
        {
            _reposistory.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _reposistory.Delete(id);
        }
    }
}
