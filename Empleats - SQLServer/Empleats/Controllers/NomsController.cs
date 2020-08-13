using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Empleats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NomsController : ControllerBase
    {
        // GET: api/Noms/nom>
        [HttpGet]
        [Route("nom")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hola mundo" };
        }
       

        /************************
         * Devuelve hola nombre *
         ************************/
        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<string> Get(string nom)
        {
            return new string[] { "Hola " + nom };
        }
        /************************/

        // POST api/<NomsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NomsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NomsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
