using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server_bakery.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server_bakery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BunController : ControllerBase
    {

        private ApplicationContext db;
        public BunController(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        [ProducesResponseType(typeof(Bun[]), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var r = await db.Buns.Where(b=>b.BunStatus==BunStatus.OnSell).ToListAsync();

            return Ok(r);

 
           



        }


        // POST api/<BunController>
        [HttpPost]
        public async Task<IActionResult> SetData([FromBody] Bun bun)

        {

            return Ok(true);
        }


    }
}
