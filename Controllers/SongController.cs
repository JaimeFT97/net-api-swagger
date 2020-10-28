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
    public class SongController : ControllerBase
    {
        private RC_DBContext builder;

        public SongController(RC_DBContext rC_DBContext)
        {
            builder = rC_DBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Song>>> Get()
        {
            return await builder.Song.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Song>> Create([FromBody] Song song)
        {
            builder.Song.Add(song);
            await builder.SaveChangesAsync();

            return song;
        }
    }
}