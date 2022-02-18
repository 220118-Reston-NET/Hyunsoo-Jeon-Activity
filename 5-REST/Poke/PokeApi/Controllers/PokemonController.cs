using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeBL;
using PokeModel;

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
        // [httpGet] data annotation basically tells the compire that the method will be an action inside of a controller
        // specifically this will handle a GET request from the client and send a http response
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllPokemonAsync()
        {
            try
            {
                return Ok(await _pokeBL.GetAllPokemonAsync());
            }
            catch (SqlException)
            {
                // the api is responsible for sending the right resource and the right status code
                // in this case, if it was unable to connect to the database, it will give a 404 status code
                return NotFound();
            }
        }

        /*
            parameterized action will help you get information from the client to do some process based on that action
            you have to use "{nameofparameter}" to specify what you need
            Dont forget to put it as a parameter on the action with the appropriate datatype
        */
        [HttpGet("{pokeName}")]
        public IActionResult GetPokemonByName(string pokeName)
        {
            try
            {
                return Ok(_pokeBL.SearchPokemon(pokeName));
            }
            catch (System.Exception)
            {
                
                return NotFound();
            }
        }

        /*
            [FronBody] data annotation specifies that this action will look insde of the HTTP request body (which is in a json format) to grab the information it needs
            usually helpful for large amount of data(creating an account)
            [HttpPost] This action will handle any post request from the client
        */
        [HttpPost("Add")]
        public IActionResult AddPokemon([FromBody] Pokemon p_poke)
        {
            try
            {
                //return Ok(_pokeBL.AddPokemon(p_poke));
                return Created("Successfully added",_pokeBL.AddPokemon(p_poke));

            }
            catch (System.Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // PUT: api/Pokemon/5
        [HttpPut("Update/{id}")]
        public IActionResult Put(int id, [FromBody] Pokemon p_poke)
        {
            p_poke.PokeId = id;
            try
            {
                return Ok(_pokeBL.UpdatePokemon(p_poke));
            }
            catch (System.Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // DELETE: api/Pokemon/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
