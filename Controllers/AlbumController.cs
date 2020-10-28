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
    public class AlbumController : ControllerBase
    {
        private RC_DBContext builder;

        public AlbumController(RC_DBContext rC_DBContext)
        {
            builder = rC_DBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Album>>> Get()
        {
            return await builder.Album.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Album>> Create([FromBody] Album album)
        {
            builder.Album.Add(album);
            await builder.SaveChangesAsync();

            return album;
        }
    }
}