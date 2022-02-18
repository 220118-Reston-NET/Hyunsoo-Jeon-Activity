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

        /// will give all pokemon in the database
        /// returns a list collection of pokemon objects
        List<Pokemon> GetAllPokemon();


        /// <summary>
        /// Will give a list of abilities from a pokemon
        /// </summary>
        /// <param name="p_pokeId">The Id of the pokemon it will search</param>
        /// <returns>list collection that holds ability objects</returns>
        List<Ability> GetAbilitiesByPokeId(int p_pokeId);

        Pokemon UpdatePokemon(Pokemon p_poke);

    }
}
