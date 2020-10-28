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
    public class LanguageController : ControllerBase
    {
        private RC_DBContext builder;

        public LanguageController(RC_DBContext rC_DBContext)
        {
            builder = rC_DBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Language>>> Get()
        {
            return await builder.Language.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Language>> Create([FromBody] Language language)
        {
            builder.Language.Add(language);
            await builder.SaveChangesAsync();

            return language;
        }
    }
}