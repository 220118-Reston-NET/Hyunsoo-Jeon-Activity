using PokeModel;

namespace PokeDL
{   
    /// <summary>
    /// - Data layer project is responsible for interacting with our database and doing CRUD operations
    /// - you must not to have logical operation that will also manipulate the data it is grabbing
    /// </summary>//  
    public interface IRepository
    {   
        /// <summary>
        /// Add a pokemon to the database
        /// </summary>
        /// <param name="p_poke">this the pokemon object we are adding to the database</param>
        /// <returns></returns>
        Pokemon AddPokemon(Pokemon p_poke);
    }
}
