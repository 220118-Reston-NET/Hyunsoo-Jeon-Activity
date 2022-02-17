using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeBL;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private IPokemonBL _pokeBL;
        public PokemonController(IPokemonBL p_pokeBL)
        {
            _pokeBL = p_pokeBL;
        }

        // GET: api/Pokemon
        [HttpGet]
        public IActionResult GetAllPokemon()
        {
            try
            {
                return Ok(_pokeBL.GetAllPokemon());
            }
            catch (SqlException)
            {
                // the api is responsible for sending the right resource and the right status code
                // in this case, if it was unable to connect to the database, it will give a 404 status code
                return NotFound();
            }
        }

        // GET: api/Pokemon/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pokemon
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Pokemon/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Pokemon/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
