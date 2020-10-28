using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using net_api_swagger.Domain;
using net_api_swagger.Infrastructure;

namespace net_api_swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private RC_DBContext builder;

        public GenderController(RC_DBContext rC_DBContext)
        {
            builder = rC_DBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gender>>> Get()
        {
            return await builder.Gender.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Gender>> Create([FromBody] Gender gender)
        {
            builder.Gender.Add(gender);
            await builder.SaveChangesAsync();

            return gender;
        }
    }
}